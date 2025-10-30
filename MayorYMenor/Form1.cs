namespace MayorYMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(txtNumero1.Text);
            int numero2 = Int32.Parse(txtNumero2.Text);
            int numero3 = Int32.Parse(txtNumero3.Text);

            /*int mayor = numero1;

            if(numero2>mayor)
            {
                mayor = numero2;
            }
            if (numero3 > mayor)
            {
                mayor = numero3;
            }
            MessageBox.Show("El numero mas grande es: " + mayor);
            int menor = numero1;
            if (numero2 < menor)
            {
                menor = numero2;
            }
            if (numero3 < menor)
            {
                menor = numero3;
            }
            MessageBox.Show("El numero mas pequeño es: " + menor);*/
            double promedio = (numero1 + numero2 + numero3);
            promedio = promedio / 3;
            MessageBox.Show("El promedio es: " + promedio);
        }
    }
}
