// Урок 7 Пример: алгоритм обхода директории (показать содержимое папок)

string Path1 = "G:/frame/Education/Geekbrains/Разработчик/04 Языки программирования/C#";  // пришлось заменить \ на / в адресе (вручную)
DirectoryInfo di = new DirectoryInfo(Path1); // класс для работы с директориями

System.Console.WriteLine(di.CreationTime); // выводим время содания папки в консоль

FileInfo[] fi = di.GetFiles(); // класс по работе с информацией о файлах

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

//_________________________________________________________________________________________________________________________________

void CatalogInfo (string Path, string Indent = "") // Метод с рекурсией - смотрим что в папках. Path - путь к текущей папке, Indent - делаем отступы (чтобы видеть струкруты папок)
{
    DirectoryInfo Catalog = new DirectoryInfo(Path); // Получаем инфо о дериктории в которую заходим

    DirectoryInfo[] Catalogs = Catalog.GetDirectories(); // записываем в массив все ПАПКИ из директории
    for (int i = 0; i < Catalogs.Length; i++)
    {
        Console.WriteLine($"{Indent}{Catalogs[i].Name}"); // выводим инфо о текущем каталоге
        CatalogInfo(Catalogs[i].FullName, Indent + "  "); // рекурсивно заныриваем и смотрим папки в папках и выводим
    }

    FileInfo[] Files = Catalog.GetFiles(); // записываем в массив весь список ФАЙЛОВ из директории текущего каталога

    for (int i = 0; i < Files.Length; i++)
    {
        Console.WriteLine($"{Indent}{Files[i].Name}"); // выводим ФАЙЛЫ на экран
    }
}

string Path2 = @"G:\frame\Education\Geekbrains\Разработчик\04 Языки программирования\C#";
CatalogInfo(Path2);


