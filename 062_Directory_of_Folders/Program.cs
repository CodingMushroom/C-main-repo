// Урок 7 Пример: алгоритм обхода директории (показать содержимое папок)

string Path = "G:/frame/Education/Geekbrains/Разработчик/04 Языки программирования/C#";  // пришлось заменить \ на / в адресе (вручную)
DirectoryInfo di = new DirectoryInfo(Path); // класс для работы с директориями

System.Console.WriteLine(di.CreationTime); // выводим время содания папки в консоль

FileInfo[] fi = di.GetFiles(); // класс по работе с информацией о файлах

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string Path, string Indent = "") // Метод с рекурсией - смотрим что в папках. Path - путь к текущей папке, Indent - делаем отступы (чтобы видеть струкруты папок)
{
    DirectoryInfo Catalog = new DirectoryInfo(path); // Получаем инфо о дериктории в которую заходим

    DirectoryInfo[] Catalogs = Catalog.GetDirectories(); // записываем в массив все файлы из директории
    for (int i = 0; i < Catalogs.Length; i++)
    {
        Console.WriteLine($"{Indent}{Catalogs[i].Name}"); // выводим инфо о текущем каталоге
        CatalogInfo(Catalogs[i].FullName, Indent + "  ");
    }

    FileInfo[] Files = Catalog.GetFiles();

}


