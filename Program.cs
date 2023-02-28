string [,] Arena (int y, int x)
{
   
    string[,] maps = new string[y, x];
    for (int i = 0; y > i; i++) // Заполнение полей по оси (у)
    {
        for(int j = 0; x > j; j++) // Заполнение полей по оси (х)
        {
            if(j == 0 || j == (x-1) || i == 0 || i == (y-1) ) 
            {
                maps[i,j] = "T";
            }
            else
            {
                maps[i,j] = " ";
            }
        }
       
    }
    return maps;
}

void ImageArena (string [,] karta)
{
     Console.Clear();
     for (int i = 0; karta.GetLength(0) > i; i++) // Заполнение полей по оси (у)
    {
        for(int j = 0; karta.GetLength(1) > j; j++) // Заполнение полей по оси (х)
        {
            if (j == (karta.GetLength(1) - 1))
            {
                Console.WriteLine(karta[i,j]);
            }else
            {
                Console.Write(karta[i,j]);
            }
            
        }
    }
}

string [,] AddedFigura (string [,] karta)
{
    int y = karta.GetLength(0);
    int x = karta.GetLength(1);
    int n = 1;
    karta[2, (x/2)] = "#";
    karta[2+n, (x/2)] = "#";
    karta[2+n, (x/2)-n] = "#";
    karta[2+n, (x/2)+n] = "#";
    return karta;
}

// string [,] Game (string [,] karta, int control)
// {
    
// }

string [,] newMaps = Arena(35,30);
ImageArena(newMaps);

AddedFigura(newMaps);
ImageArena(newMaps);

