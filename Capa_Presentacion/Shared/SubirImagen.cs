using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Shared
{
    public class SubirImagen
    {
        NegocioUsuarios negUsu = new NegocioUsuarios();

        private string GenerateFileName(string baseName)
        {
            string uniqueName = $"{baseName}_{Guid.NewGuid().ToString("N").Substring(0, 8)}";

            while (negUsu.ValidarAtributo("ValidarNombreImagen", uniqueName))
            {
                uniqueName = $"{baseName}_{Guid.NewGuid().ToString("N").Substring(0, 8)}";
            }

            return uniqueName;
        }

        public string SaveImageToFile(string ruta, string fileName)
        {
            byte[] imageBytes = File.ReadAllBytes(ruta);

            string uniqueFileName = GenerateFileName(fileName);
            string binFolderPath = Path.Combine(Application.StartupPath, "..", "..", "Imagenes");
            Directory.CreateDirectory(binFolderPath);
            string binFilePath = Path.Combine(binFolderPath, $"{uniqueFileName}.bin");

            using (FileStream fs = new FileStream(binFilePath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(imageBytes);
                }
            }

            return $"{uniqueFileName}.bin";
        }

        public void LoadImageToPictureBox(string imageName, PictureBox pictureBox)
        {
            string binFilePath = Path.Combine(Application.StartupPath, "..", "..", "Imagenes", $"{imageName}.bin");

            if (File.Exists(binFilePath))
            {
                using (FileStream fs = new FileStream(binFilePath, FileMode.Open))
                {
                    byte[] imageBytes = new byte[fs.Length];
                    fs.Read(imageBytes, 0, imageBytes.Length);

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Bitmap image = (Bitmap)Image.FromStream(ms);
                        pictureBox.Image = image;
                    }
                }
            }
            else
            {
                MessageBox.Show("Archivo no encontrado.");
            }
        }

    }
}
