using System;
using System.IO;

namespace _001_factory_pattern
{
    class Program
    {

        // Factory インターフェイス
        internal interface FactoryIF {
            FileIF Create(string fileName);
        }

        // File インターフェイス
        internal interface FileIF {
            void Read();
        }

        // Factory ファイル
        internal class FactoryFile : FactoryIF {

            public FileIF Create(string fileName) {

                FileIF file = null;
                string extension = Path.GetExtension(fileName);

                switch (extension) {
                    case ".txt": file = new TxtFile(); break;
                    case ".xml": file = new TxtFile(); break;
                }

                return file;
            }
        }

        // テキスト ファイル
        internal class TxtFile : FileIF {
            public void Read() {
                return;
            }
        }

        // XML ファイル
        internal class XmlFile : FileIF {
            public void Read() {
                return;
            }
        }

        // メイン関数
        static void Main(string[] args) {

            FactoryIF fileFactory = new FactoryFile();
            FileIF txtFile = fileFactory.Create("hoge.txt");
            FileIF xmlFile = fileFactory.Create("hoge.xml");

            txtFile.Read();
            xmlFile.Read();

            return;
        }
    }
}
