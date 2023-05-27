using Newtonsoft.Json;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает сериализацию проекта.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Путь до системной папки AppData.
        /// </summary>
        private static string _appDataFolderPath = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Путь до папки, содержащей сохраняемый файл со списком контактов.
        /// </summary>
        private static string _contactAppFolderPath = 
            $"{_appDataFolderPath}\\Emelyanov\\ContactsApp";

        /// <summary>
        /// Путь до файла, содержащего список контактов программы.
        /// </summary>
        private static string _saveFilePath = 
            _contactAppFolderPath + "\\userdata.json";

        /// <summary>
        /// Возвращает путь до папки, содержащей файл со списком контактов.
        /// </summary>
        public static string ContactAppFolderPath
        {
            get { return _contactAppFolderPath; }
            set { _contactAppFolderPath = value; }
        }

        /// <summary>
        /// Возвращает путь до файла со списком контактов.
        /// </summary>
        public static string SaveFilePath 
        { 
            get{ return _saveFilePath; }
            set{ _saveFilePath = value; }
        }

        /// <summary>
        /// Метод сохранения списка контактов в файл.
        /// </summary>
        /// <param name="project">Проект со списком контактов.</param>
        public static void SaveToFile(Project project)
        {
            JsonSerializer serializer = new();

            if (!Directory.Exists(ContactAppFolderPath)) 
            {
                Directory.CreateDirectory(ContactAppFolderPath);
            }

            if (!File.Exists(SaveFilePath))
            {              
                File.Create(SaveFilePath).Close();
            }

            using (StreamWriter sw = new StreamWriter(SaveFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод загрузки списка контактов из файла.
        /// </summary>
        /// <returns></returns>
        public static Project LoadFromFile()
        {
            Project project; 
            
            if (!File.Exists(SaveFilePath))
            {
                return new Project();
            }

            var jsonFilePath = File.ReadAllText(SaveFilePath);
            project = JsonConvert.DeserializeObject<Project>(jsonFilePath);
            if (project == null)
            {
                return new Project();
            }

            return project;
        }
    }
}
