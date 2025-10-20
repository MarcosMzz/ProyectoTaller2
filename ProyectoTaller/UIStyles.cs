using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection; // <-- ¡IMPORTANTE! Agrega esta línea al principio.

public static class UIStyles
{
    // Colores de tu paleta
    private static Color AccentColor = Color.Red;
    private static Color BaseColor = Color.White;
    private static Color TextColor = Color.Black;
    private static Color HoverBackgroundColor = Color.FromArgb(255, 230, 230); // Un gris muy claro

    private static void Button_MouseEnter(object sender, EventArgs e)
    {
        Button boton = sender as Button;
        if (boton != null)
        {
            boton.BackColor = HoverBackgroundColor;
            boton.FlatAppearance.BorderSize = 2; // Borde más grueso
        }
    }

    private static void Button_MouseLeave(object sender, EventArgs e)
    {
        Button boton = sender as Button;
        if (boton != null)
        {
            boton.BackColor = BaseColor;
            boton.FlatAppearance.BorderSize = 1; // Borde normal
        }
    }

    public static void AddHoverEffectToAllButtons(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is Button boton)
            {
                // Configuración inicial del botón
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 1;
                boton.FlatAppearance.BorderColor = AccentColor;
                boton.BackColor = BaseColor;
                boton.ForeColor = TextColor;

                // --- AQUÍ ESTÁ LA MAGIA ---
                // Usamos Reflection para llamar al método protegido 'SetStyle'
                MethodInfo setStyleMethod = typeof(Control).GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance);
                if (setStyleMethod != null)
                {
                    setStyleMethod.Invoke(boton, new object[] { ControlStyles.Selectable, false });
                }
                // --- FIN DE LA MAGIA ---

                // Asignamos nuestros eventos de hover
                boton.MouseEnter += new EventHandler(Button_MouseEnter);
                boton.MouseLeave += new EventHandler(Button_MouseLeave);
            }
            if (control.HasChildren)
            {
                AddHoverEffectToAllButtons(control);
            }
        }
    }
}