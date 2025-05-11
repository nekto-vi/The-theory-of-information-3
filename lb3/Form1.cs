using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb3
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private byte[] data;

        private List<BigInteger> primitiveRoots = new List<BigInteger>();
        private BigInteger p, g, x, y, k;

        public Form1()
        {
            InitializeComponent();
            EncOrDec.Items.AddRange(new string[] { "Шифрование", "Дешифрование" });
            EncOrDec.SelectedIndex = 0;
        }

        private async void FileSelectionButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите файл";
                openFileDialog.Filter = "Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    SelectedFile.Text = Path.GetFileName(filePath);

                    await Task.Run(() =>
                    {
                        data = File.ReadAllBytes(filePath);
                    });

                    FileInfoOrig.Text = string.Join(" ", data.Take(32).Select(b => b.ToString())) +
                                      (data.Length > 32 ? " ... " + string.Join(" ", data.Skip(data.Length - 32).Select(b => b.ToString())) : "");
                }
            }
        }

        private void CleanAllButton_Click(object sender, EventArgs e)
        {
            SelectedFile.Text = string.Empty;
            //ValueP.Text = string.Empty;
            //ValueX.Text = string.Empty;
            //ValueK.Text = string.Empty;
            //OpenKey.Text = string.Empty;
            FileInfoOrig.Text = string.Empty;
            FileInfoEncrypted.Text = string.Empty;
            EncOrDec.SelectedIndex = 0;
            primitiveRoots.Clear();
            PrimitiveValue.Items.Clear();
            data = null;
            filePath = "";
        }

        private void CalculateOpenKeyButton_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(ValueP.Text, out p) || !IsPrime(p) || p < 2)
            {
                MessageBox.Show("p должно быть простым числом.");
                return;
            }

            if (!BigInteger.TryParse(ValueX.Text, out x) || x <= 1 || x >= p - 1)
            {
                MessageBox.Show("x должно быть целым числом.");
                return;
            }

            string currentSelectedText = PrimitiveValue.Text;
            primitiveRoots = FindPrimitiveRoots(p);

            PrimitiveValue.Items.Clear();
            foreach (var root in primitiveRoots)
            {
                PrimitiveValue.Items.Add(root.ToString());
            }

            if (!string.IsNullOrEmpty(currentSelectedText))
            {
                int index = PrimitiveValue.Items.IndexOf(currentSelectedText);
                if (index >= 0)
                {
                    PrimitiveValue.SelectedIndex = index;
                }
                else if (PrimitiveValue.Items.Count > 0)
                {
                    PrimitiveValue.SelectedIndex = 0;
                }
            }
            else if (PrimitiveValue.Items.Count > 0)
            {
                PrimitiveValue.SelectedIndex = 0;
            }

            UpdateKeysFromSelectedG();
        }

        private void UpdateKeysFromSelectedG()
        {
            if (PrimitiveValue.SelectedIndex >= 0 &&
                PrimitiveValue.SelectedIndex < primitiveRoots.Count &&
                BigInteger.TryParse(ValueX.Text, out x) &&
                x > 1 && x < p - 1)
            {
                g = primitiveRoots[PrimitiveValue.SelectedIndex];
                y = BigInteger.ModPow(g, x, p);
                OpenKey.Text = $"p = {p}, g = {g}, y = {y}";
            }
        }

        private List<BigInteger> FindPrimitiveRoots(BigInteger p)
        {
            List<BigInteger> roots = new List<BigInteger>();
            BigInteger phi = p - 1;
            var factors = GetUniquePrimeFactors(phi);

            for (BigInteger g = 2; g < p; g++)
            {
                bool isPrimitiveRoot = true;
                foreach (var factor in factors)
                {
                    if (BigInteger.ModPow(g, phi / factor, p) == 1)
                    {
                        isPrimitiveRoot = false;
                        break;
                    }
                }
                if (isPrimitiveRoot)
                {
                    roots.Add(g);
                }
            }
            return roots;
        }

        private List<BigInteger> GetUniquePrimeFactors(BigInteger n)
        {
            List<BigInteger> factors = new List<BigInteger>();
            if (n == 1) return factors;

            while (n % 2 == 0)
            {
                if (!factors.Contains(2))
                    factors.Add(2);
                n /= 2;
            }

            for (BigInteger i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    if (!factors.Contains(i))
                        factors.Add(i);
                    n /= i;
                }
            }

            if (n > 2 && !factors.Contains(n))
                factors.Add(n);

            return factors;
        }

        private bool IsPrime(BigInteger n)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;

            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            for (int a = 2; a <= 5; a++)
            {
                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;

                for (int i = 0; i < s - 1; i++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }
            return true;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (data == null || data.Length == 0)
            {
                MessageBox.Show("Сначала выберите файл.");
                return;
            }

            if (PrimitiveValue.SelectedIndex < 0 || PrimitiveValue.SelectedIndex >= primitiveRoots.Count)
            {
                MessageBox.Show("Выберите первообразный корень g.");
                return;
            }

            g = primitiveRoots[PrimitiveValue.SelectedIndex];

            if (EncOrDec.SelectedIndex == 0)
            {
                if (!BigInteger.TryParse(ValueP.Text, out p) || !IsPrime(p))
                {
                    MessageBox.Show("p должно быть простым числом.");
                    return;
                }

                if (!BigInteger.TryParse(ValueK.Text, out k) || k <= 1 || k >= p - 1 || BigInteger.GreatestCommonDivisor(k, p - 1) != 1)
                {
                    MessageBox.Show("k должно быть целым числом, взаимно простым с p-1.");
                    return;
                }

                var encrypted = EncryptData(data, p, g, y, k);
                data = encrypted;
            }
            else 
            {
                if (!BigInteger.TryParse(ValueP.Text, out p) || !IsPrime(p))
                {
                    MessageBox.Show("p должно быть простым числом.");
                    return;
                }

                if (!BigInteger.TryParse(ValueX.Text, out x) || x <= 1 || x >= p - 1)
                {
                    MessageBox.Show("x должно быть целым числом.");
                    return;
                }

                var decrypted = DecryptData(data, p, x);
                FileInfoEncrypted.Text = string.Join(" ", decrypted.Take(32).Select(b => b.ToString())) +
                    (decrypted.Length > 32 ? " ... " + string.Join(" ", decrypted.Skip(decrypted.Length - 32).Select(b => b.ToString())) : "");

                data = decrypted;
            }
        }

        private byte[] EncryptData(byte[] data, BigInteger p, BigInteger g, BigInteger y, BigInteger k)
        {
            List<byte> result = new List<byte>();
            StringBuilder outputBuilder = new StringBuilder();

            BigInteger a = BigInteger.ModPow(g, k, p);
            byte[] aBytes = GetFixedSizeBytes(a, 4);

            for (int i = 0; i < data.Length; i++)
            {
                byte m = data[i];
                if (m >= p)
                {
                    MessageBox.Show("Ошибка: значение байта больше p!");
                    return new byte[0];
                }

                BigInteger y_pow_k = BigInteger.ModPow(y, k, p);
                BigInteger b = (y_pow_k * m) % p;
                byte[] bBytes = GetFixedSizeBytes(b, 4);

                result.AddRange(aBytes);
                result.AddRange(bBytes);

                if (i < 10 || i >= data.Length - 10)
                {
                    outputBuilder.Append($"{{{a}, {b}}} ");
                    if (i == 9 && data.Length > 20) outputBuilder.Append("... ");
                }
            }

            FileInfoEncrypted.Invoke((MethodInvoker)(() =>
            {
                FileInfoEncrypted.Text = outputBuilder.ToString().Trim();
            }));

            return result.ToArray();
        }

        private byte[] DecryptData(byte[] encryptedData, BigInteger p, BigInteger x)
        {
            List<byte> result = new List<byte>();
            int position = 0;
            const int pairSize = 8; 

            while (position + pairSize <= encryptedData.Length)
            {
                byte[] aBytes = new byte[4];
                Array.Copy(encryptedData, position, aBytes, 0, 4);
                position += 4;
                BigInteger a = new BigInteger(aBytes);

                byte[] bBytes = new byte[4];
                Array.Copy(encryptedData, position, bBytes, 0, 4);
                position += 4;
                BigInteger b = new BigInteger(bBytes);

                BigInteger a_pow = BigInteger.ModPow(a, p - 1 - x, p);
                BigInteger m = (b * a_pow) % p;

                if (m < 0 || m > 255)
                {
                    MessageBox.Show($"Ошибка.");
                    return new byte[0];
                }

                result.Add((byte)m);
            }

            return result.ToArray();
        }

        private byte[] GetFixedSizeBytes(BigInteger value, int size)
        {
            byte[] bytes = value.ToByteArray();
            byte[] result = new byte[size];

            int bytesToCopy = Math.Min(bytes.Length, size);
            Array.Copy(bytes, 0, result, 0, bytesToCopy);

            if (value.Sign < 0 && bytesToCopy < size)
            {
                for (int i = bytesToCopy; i < size; i++)
                    result[i] = 0xFF;
            }

            return result;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (data == null || data.Length == 0)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Все файлы (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, data);
                    MessageBox.Show("Файл успешно сохранен.");
                }
            }
        }
    }
}