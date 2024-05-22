using System;
using System.Collections.Generic;

public class UserData
{
    public int ID { get; set; }
    public string UserName { get; set; }
    public List<float> Scores { get; set; }

    public UserData(int id, string userName)
    {
        ID = id;
        UserName = userName;
        Scores = new List<float>();
    }
}