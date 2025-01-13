using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace session04.Utils;
public static class DynamicFormUtils
{
    public static void DesignForm(this Control target, Type type)
    {
        int yOffest = 20;
        foreach (var propertyInfo in type.GetProperties())
        {
            
            var label = new Label
            {
                Text = propertyInfo.Name + ": ",
                Location = new Point(20, yOffest),
                AutoSize = true,
            };
            var display = propertyInfo.GetCustomAttribute(typeof(DisplayAttribute));
            if (display is DisplayAttribute dis)
            {
                label.Text = dis.Name;
            }

            var control = CreateControl(propertyInfo.PropertyType);
            control.Location = new Point(200, yOffest);
            control.Width = 200;
            control.Tag = propertyInfo; //Cache

            target.Controls.Add(label);
            target.Controls.Add(control);

            yOffest += 30;
        }
    }

    public static void SetFormData(this Control target, object model)
    {
        foreach (Control control in target.Controls)
        {
           if(control.Tag is PropertyInfo property)
            {
                if(control is TextBox textBox)
                {
                    textBox.Text = Convert.ToString(property.GetValue(model));
                }
                if (control is NumericUpDown numeric)
                {                    
                    numeric.Value = Convert.ToInt32(property.GetValue(model));
                }
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = Convert.ToBoolean(property.GetValue(model));
                }
            }
        }
    }

    public static object GetFormData(this Control target, Type type)
    {        
        var model = Activator.CreateInstance(type);
        foreach (Control control in target.Controls)
        {
            if (control.Tag is PropertyInfo property)
            {
                object value = null;
                if (control is TextBox textBox)
                {
                    value = textBox.Text;
                }
                if (control is NumericUpDown numeric)
                {
                    value =Convert.ToInt32(numeric.Value);
                }
                if (control is CheckBox checkBox)
                {
                    value = checkBox.Checked;
                }
                property.SetValue(model, value);
            }
        }

        return model;
    }


    private static Control CreateControl (Type Prop)
    {
        if (Prop == typeof(int))
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Maximum = int.MaxValue;
            return numericUpDown;
        };
        if (Prop == typeof(string)) return new TextBox();
        if (Prop == typeof(Boolean)) return new CheckBox();
        return new Control();
    }
}
