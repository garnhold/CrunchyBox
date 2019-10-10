using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySauce;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorSceneElement_EditGadgetInstance_Paintable : EditorSceneElement_EditGadgetInstance
    {
        private NowMesh brush_now_mesh;
        private NowMesh surface_now_mesh;

        private Vector2 last_texture_point;
        private SurfaceTool_Line_Basic_Straight<Color> line_tool;

        protected override void DrawInternal()
        {
            GUIControlHandle handle = GUIExtensions.GetControlHandle(FocusType.Passive);

            Texture2D texture = this.GetContents<Texture2D>();
            Vector3 position = this.GetAuxContents<Vector3>("position");
            Quaternion rotation = this.GetAuxContents<Quaternion>("rotation");
            Vector2 size = this.GetAuxContents<Vector2>("size");
            bool is_overlay_enabled = this.GetAuxContents<bool>("is_overlay_enabled");

            Surface<Color> surface = texture.GetSurface();
            Utensil<Color> utensil = Painter.GetInstance().GetUtensil();

            Matrix4x4 transform = Matrix4x4.TRS(position, rotation, size.GetSpacar(1.0f));
            Matrix4x4 inv_transform = transform.inverse;
            
            Vector3 world_point = Camera.current.ScreenToWorldPlanePoint(
                transform.MultiplyPlane(PlaneExtensions.CreateNormalAndPoint(new Vector3(0.0f, 0.0f, 1.0f), Vector3.zero)),
                handle.GetEvent().mousePosition.ConvertFromGUIToScreen()
            );

            Vector3 local_point = inv_transform.MultiplyPoint(world_point);
            Vector2 texture_point = local_point.GetComponentMultiply(texture.GetSize()).GetPlanar() + 0.5f * texture.GetSize();

            Vector3 brush_size = new Vector2(Painter.GetInstance().GetBrushSize(), Painter.GetInstance().GetBrushSize())
                .GetComponentDivide(texture.GetSize())
                .GetComponentMultiply(size)
                .GetSpacar(1.0f);

            if (handle.IsControlCaptured() && is_overlay_enabled)
            {
                surface_now_mesh.GetMaterial().SetMainTexture(texture);
                surface_now_mesh.Draw(transform);
            }

            brush_now_mesh.Draw(world_point, rotation, brush_size);

            if (handle.GetEventType().IsMouseRelated() && handle.GetEvent().button == 0)
            {
                if (handle.GetEventType() == EventType.MouseDown)
                {
                    handle.CaptureControl();

                    this.Execute("MouseDown");
                    last_texture_point = texture_point;
                }

                if (handle.GetEventType() == EventType.MouseUp)
                {
                    handle.ReleaseControl();

                    this.Execute("MouseUp");
                }

                if (handle.IsControlCaptured())
                {
                    line_tool.MarkLines(surface, utensil, last_texture_point.GetVectorF2(), texture_point.GetVectorF2());
                    texture.Apply();
                }

                last_texture_point = texture_point;
                handle.UseEvent();
            }
        }

        public EditorSceneElement_EditGadgetInstance_Paintable(EditGadgetInstance g) : base(g)
        {
            brush_now_mesh = new NowMesh(
                MeshExtensions.CreateCircleOutline(0.03f, 32),
                MaterialExtensions.CreateUnlitColorMaterial(Color.black)
            );

            surface_now_mesh = new NowMesh(
                MeshExtensions.CreateCenterQuad(),
                MaterialExtensions.CreateUnlitTransparentTextureMaterial(null)
            );

            last_texture_point = new Vector2();
            line_tool = new SurfaceTool_Line_Basic_Straight<Color>(0.1f);
        }
    }
}