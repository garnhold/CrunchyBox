using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class ByteDelta
	{
		private byte previous;
        private byte delta;
        
        private bool is_initialized;
        
        public ByteDelta()
        {
            Clear();
        }
        
        public ByteDelta(byte v) : this()
        {
            Update(v);
        }
        
        public void Clear()
        {
            previous = 0;
            delta = 0;
        
            is_initialized = false;
        }
        
        public void Update(byte value)
        {
            if(is_initialized)
                delta = (byte)(value - previous);
            else
            {
                delta = 0;
                is_initialized = true;
            }
            
            previous = value;
        }
        
        public byte UpdateDelta(byte value)
        {
            Update(value);
            
            return GetDelta();
        }
        
        public byte GetValue()
        {
            return previous;
        }
        
        public byte GetDelta()
        {
            return delta;
        }
	}

    public class ShortDelta
	{
		private short previous;
        private short delta;
        
        private bool is_initialized;
        
        public ShortDelta()
        {
            Clear();
        }
        
        public ShortDelta(short v) : this()
        {
            Update(v);
        }
        
        public void Clear()
        {
            previous = 0;
            delta = 0;
        
            is_initialized = false;
        }
        
        public void Update(short value)
        {
            if(is_initialized)
                delta = (short)(value - previous);
            else
            {
                delta = 0;
                is_initialized = true;
            }
            
            previous = value;
        }
        
        public short UpdateDelta(short value)
        {
            Update(value);
            
            return GetDelta();
        }
        
        public short GetValue()
        {
            return previous;
        }
        
        public short GetDelta()
        {
            return delta;
        }
	}

    public class IntDelta
	{
		private int previous;
        private int delta;
        
        private bool is_initialized;
        
        public IntDelta()
        {
            Clear();
        }
        
        public IntDelta(int v) : this()
        {
            Update(v);
        }
        
        public void Clear()
        {
            previous = 0;
            delta = 0;
        
            is_initialized = false;
        }
        
        public void Update(int value)
        {
            if(is_initialized)
                delta = (int)(value - previous);
            else
            {
                delta = 0;
                is_initialized = true;
            }
            
            previous = value;
        }
        
        public int UpdateDelta(int value)
        {
            Update(value);
            
            return GetDelta();
        }
        
        public int GetValue()
        {
            return previous;
        }
        
        public int GetDelta()
        {
            return delta;
        }
	}

    public class LongDelta
	{
		private long previous;
        private long delta;
        
        private bool is_initialized;
        
        public LongDelta()
        {
            Clear();
        }
        
        public LongDelta(long v) : this()
        {
            Update(v);
        }
        
        public void Clear()
        {
            previous = 0;
            delta = 0;
        
            is_initialized = false;
        }
        
        public void Update(long value)
        {
            if(is_initialized)
                delta = (long)(value - previous);
            else
            {
                delta = 0;
                is_initialized = true;
            }
            
            previous = value;
        }
        
        public long UpdateDelta(long value)
        {
            Update(value);
            
            return GetDelta();
        }
        
        public long GetValue()
        {
            return previous;
        }
        
        public long GetDelta()
        {
            return delta;
        }
	}

    public class FloatDelta
	{
		private float previous;
        private float delta;
        
        private bool is_initialized;
        
        public FloatDelta()
        {
            Clear();
        }
        
        public FloatDelta(float v) : this()
        {
            Update(v);
        }
        
        public void Clear()
        {
            previous = 0;
            delta = 0;
        
            is_initialized = false;
        }
        
        public void Update(float value)
        {
            if(is_initialized)
                delta = (float)(value - previous);
            else
            {
                delta = 0;
                is_initialized = true;
            }
            
            previous = value;
        }
        
        public float UpdateDelta(float value)
        {
            Update(value);
            
            return GetDelta();
        }
        
        public float GetValue()
        {
            return previous;
        }
        
        public float GetDelta()
        {
            return delta;
        }
	}

    public class DoubleDelta
	{
		private double previous;
        private double delta;
        
        private bool is_initialized;
        
        public DoubleDelta()
        {
            Clear();
        }
        
        public DoubleDelta(double v) : this()
        {
            Update(v);
        }
        
        public void Clear()
        {
            previous = 0;
            delta = 0;
        
            is_initialized = false;
        }
        
        public void Update(double value)
        {
            if(is_initialized)
                delta = (double)(value - previous);
            else
            {
                delta = 0;
                is_initialized = true;
            }
            
            previous = value;
        }
        
        public double UpdateDelta(double value)
        {
            Update(value);
            
            return GetDelta();
        }
        
        public double GetValue()
        {
            return previous;
        }
        
        public double GetDelta()
        {
            return delta;
        }
	}

    public class DecimalDelta
	{
		private decimal previous;
        private decimal delta;
        
        private bool is_initialized;
        
        public DecimalDelta()
        {
            Clear();
        }
        
        public DecimalDelta(decimal v) : this()
        {
            Update(v);
        }
        
        public void Clear()
        {
            previous = 0;
            delta = 0;
        
            is_initialized = false;
        }
        
        public void Update(decimal value)
        {
            if(is_initialized)
                delta = (decimal)(value - previous);
            else
            {
                delta = 0;
                is_initialized = true;
            }
            
            previous = value;
        }
        
        public decimal UpdateDelta(decimal value)
        {
            Update(value);
            
            return GetDelta();
        }
        
        public decimal GetValue()
        {
            return previous;
        }
        
        public decimal GetDelta()
        {
            return delta;
        }
	}

}

