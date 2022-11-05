using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormDangnhapDangKy.Controllers
{
    internal class FilesServices
    {
        public List<T> ReadSVfromXML<T>(string path) // Đọc xml
        {
            if (!File.Exists(path))// Kiểm tra xem file có tồn tại hay không
            {
                Console.WriteLine("File không tồn đại, đề nghị thí chủ kiểm tra lại"); return null;
            }
            else
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        var listSV = (List<T>)xs.Deserialize(fs);
                        return listSV;
                    }
                }catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public void WriteSVtoXML<T>(string path, T doituong) // Ghi vào xml 1 đối tượng lấy từ form
        {
            if (!File.Exists(path))// Kiểm tra xem file xó tồn tại hay không
            {
                Console.WriteLine("File không tồn đại, đề nghị thí chủ kiểm tra lại");
            }
            else
            {
                try
                {
                    List<T> listdoituong = ReadSVfromXML<T>(path); // đọc từ file ra cái list cũ
                    listdoituong.Add(doituong);// thêm đối tượng mới tạo vào 
                    XmlSerializer xs = new XmlSerializer(typeof(List<T>));

                    using (StreamWriter tw = new StreamWriter(path))
                    {
                        xs.Serialize(tw, listdoituong); tw.Close();
                    }
                }
                catch (Exception)
                {
                    List<T> listdoituong = new List<T>();
                    listdoituong.Add(doituong);
                    XmlSerializer xs = new XmlSerializer(typeof(List<T>));

                    using (StreamWriter tw = new StreamWriter(path))
                    {
                        xs.Serialize(tw, listdoituong); tw.Close();
                    }
                }
            }
        }
    }
}
