using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.ComponentModel.Design.Serialization;
using System.Reflection;

namespace CustomerControl
{
    public class MyListControl : Control
    {
        private List<Int32> _list = new List<Int32>();
        private Scope _scope;

        public MyListControl()
        {

        }

        [Browsable(true),
         Category("设置集合"),
         Description("设置一个集合吧")
        ]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        public List<Int32> Item
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }

        [Browsable(true)]
        public Scope Scope
        {
            get
            {
                return _scope;
            }
            set
            {
                _scope = value;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            //绘制控件的边框

            g.DrawRectangle(Pens.Black, new Rectangle(Point.Empty, new Size(Size.Width - 1, Size.Height - 1)));

            for (Int32 i = 0; i < _list.Count; i++)
            {
                g.DrawString(_list[i].ToString(), Font, Brushes.Black, 1, i * FontHeight);
            }
        }
    }

    [TypeConverter(typeof(ScopeConverter))]
    public class Scope
    {
        private Int32 _min;
        private Int32 _max;

        public Scope()
        {
        }

        public Scope(Int32 min, Int32 max)
        {
            _min = min;
            _max = max;
        }

        [Browsable(true)]
        public Int32 Min
        {
            get
            {
                return _min;
            }
            set
            {
                _min = value;
            }
        }

        [Browsable(true)]
        public Int32 Max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
            }

        }
    }


    public class ScopeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(String)) return true;

            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(String)) return true;

            if (destinationType == typeof(InstanceDescriptor)) return true;

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            String result = "";
            if (destinationType == typeof(String))
            {
                Scope scope = (Scope)value;
                result = scope.Min.ToString() + "," + scope.Max.ToString();
                return result;

            }

            if (destinationType == typeof(InstanceDescriptor))
            {
                ConstructorInfo ci = typeof(Scope).GetConstructor(new Type[] { typeof(Int32), typeof(Int32) });
                Scope scope = (Scope)value;
                return new InstanceDescriptor(ci, new object[] { scope.Min, scope.Max });
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                String[] v = ((String)value).Split(',');
                if (v.GetLength(0) != 2)
                {
                    throw new ArgumentException("Invalid parameter format");
                }

                Scope csf = new Scope();
                csf.Min = Convert.ToInt32(v[0]);
                csf.Max = Convert.ToInt32(v[1]);
                return csf;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(Scope), attributes);
        }
    }
}
