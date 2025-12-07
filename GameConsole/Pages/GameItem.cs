using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base;

public abstract class GameItem
{
    public string Name { get; set; }
    public int Score { get; set; }

    public GameItem(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public abstract void Play();
    

}
