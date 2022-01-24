using System;
using System.IO;
using System.Xml;

using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;

    [ScriptedImporter(1, "tmx")]
    public class TiledMapAssetImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext context)
        {
            TiledMapAsset asset = TiledMapAsset.CreateInstance<TiledMapAsset>();

            XmlDocument document = new XmlDocument();
            document.LoadXml(File.ReadAllText(context.assetPath));

            XmlNode map = document.ChildNodes.Bridge<XmlNode>().FindFirst(n => n.Name == "map");
            if (map == null)
                throw new Exception("Missing <map> element");

            XmlNode layer = map.ChildNodes.Bridge<XmlNode>().FindFirst(n => n.Name == "layer");
            if (layer == null)
                throw new Exception("Missing <layer> element");

            XmlAttribute width = layer.Attributes.Bridge<XmlAttribute>().FindFirst(n => n.Name == "width");
            if (width == null)
                throw new Exception("Missing <width> attribute");

            XmlAttribute height = layer.Attributes.Bridge<XmlAttribute>().FindFirst(n => n.Name == "height");
            if (height == null)
                throw new Exception("Missing <height> attribute");

            XmlNode data = layer.ChildNodes.Bridge<XmlNode>().FindFirst(n => n.Name == "data");
            if (data == null)
                throw new Exception("Missing <data> element");

            XmlAttribute encoding = data.Attributes.Bridge<XmlAttribute>().FindFirst(n => n.Name == "encoding");
            if (encoding == null)
                throw new Exception("Missing <encoding> attribute");

            if (encoding.InnerText != "csv")
                throw new Exception("Only csv encoding is supported");

            string text = data.InnerText;

            asset.Initialize(
                width.InnerText.ParseInt(),
                height.InnerText.ParseInt(),
                data.InnerText.SplitOn(",").Convert(s => s.ParseInt())
            );

            context.AddObjectToAsset("tmx", asset);
            context.SetMainObject(asset);
        }
    }
}