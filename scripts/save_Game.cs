using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class save_Game 
{
    public static void saveLevel(Frog_Move frog)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/V1.1Load_Frog";
        FileStream stream = new FileStream(path, FileMode.Create);

        play_DATA data = new play_DATA(frog);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.LogError("It converted to bins " + path);
    }

    public static play_DATA loadLevel()
    {
        string path = Application.persistentDataPath + "/V1.1Load_Frog";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            play_DATA data = formatter.Deserialize(stream) as play_DATA;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("File not Found in shit for brains " + path);
            return null;
        }
    }
}
