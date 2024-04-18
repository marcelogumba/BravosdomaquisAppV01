using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace BravosdomaquisApp.Config
{
    public static class ConversorFiles
    {
        public static async Task<System.Drawing.Image> ConverterParaImagem(string caminho)
        {
            var result = await ServiceBase.service().GetImageAsync($"files/imagens/{caminho}");
            using (MemoryStream memoryStream = new MemoryStream(result))
            {
                // Use o método FromStream para criar a imagem
                System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);

                // Agora você pode usar a imagem como precisar
                // Por exemplo, exibindo em um PictureBox:
                return image;
            }
        }

        public static  async Task<string> ConverterParaPDF(string caminho)
        {
            //aqui é retornado um byte[]
            var result = await ServiceBase.service().GetImageAsync($"files/PDF/{caminho}");
            using (MemoryStream memoryStream = new MemoryStream(result))
            {

                // Crie um PdfReader para ler o conteúdo do MemoryStream
                PdfReader pdfReader = new PdfReader(memoryStream);


                string tempFilePath = Path.GetTempFileName();
                File.WriteAllBytes(tempFilePath, result);
                return tempFilePath;

            }
        }

    }
}
