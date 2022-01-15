using System;

class Program {
  public static void Main (string[] args) {
    char [,] pixel = new char[4,13];
    char [,] Mirror_pixel = new char[4,13];
    char [,] Fused_pixel = new char [4,26];
    //printing normal Car
    for (int i = 0; i < 4; i++){
      for (int j = 0; j < 13; j++){
        pixel = make_forward();
        Console.Write(pixel[i,j]);
      }
      Console.WriteLine(" ");
    }
    //printing mirror Car
  
     for (int i = 0; i < 4; i++){
      for (int j = 0; j < 13; j++){
        Mirror_pixel = mirror_Car(pixel);
        Console.Write(Mirror_pixel[i,j]);
      }
      Console.WriteLine(" ");
    }
    //priting foward and mirror Car
    for (int i = 0; i < 4; i++){
      for (int j = 0; j < 26; j++){
      Fused_pixel = combine_Cars(pixel, Mirror_pixel);
      Console.Write(Fused_pixel[i,j]);
    }
    Console.WriteLine(" ");
    }
  }
  public static char [,] combine_Cars(char[,] pixel, char[,] Mirror_pixel){
    //fill in first car (normal)
    char [,] Fused_pixel = new char[4,26];
    for (int i = 0; i < 4; i++){
      for (int j = 0; j < 13; j++){
        Fused_pixel[i,j] = pixel[i,j];
      }
    }
    for (int i = 0; i < 4; i++){
      for (int j = 13; j < 26; j++){
        Fused_pixel[i,j] = Mirror_pixel[i,j-13];
      }
    }
    return Fused_pixel;
  }

  public static char [,] mirror_Car(char [,] pixel){
    char [,] Mirror_pixel = new char[4,13];
    for (int i = 0; i < 4; i++){
      for (int j = 0; j < 13; j++){
        switch (pixel[i,j]){
          case '(':
          Mirror_pixel [i,12-j] = ')';
          break;
          case ')':
          Mirror_pixel [i,12-j] = '(';
          break;
          case '/':
          Mirror_pixel [i,12-j] = '\\';
          break;
          case '\\':
          Mirror_pixel [i,12-j] = '/';
          break;
          default:
          Mirror_pixel [i,12-j] = pixel[i,j];
          break;
        }
      }
    }
    return Mirror_pixel;
  }
  public static char [,] make_forward () 
  {
    char [,] pixel = new char [ 4,13 ];
      pixel[0,0]=' ';
      pixel[0,1]=' '; 
      pixel[0,2]='_'; 
      pixel[0,3]='_';
      pixel[0,4]='_';
      pixel[0,5]='_'; 
      pixel[0,6]='_';
      pixel[0,7]='_'; 
      pixel[0,8]=' ';
      pixel[0,9]=' ';    
      pixel[0,10]=' ';
      pixel[0,11]=' ';
      pixel[0,12]=' ';
      pixel[1,0]=' ';
      pixel[1,1]='/';
      pixel[1,2]='|';
      pixel[1,3]='_';
      pixel[1,4]='|';
      pixel[1,5]='|';
      pixel[1,6]='_';
      pixel[1,7]='\\';
      pixel[1,8]='\'';
      pixel[1,9]='.';
      pixel[1,10]='_';
      pixel[1,11]='_';
      pixel[1,12]=' ';
      pixel[2,0]='(';
      pixel[2,1]=' ';
      pixel[2,2]=' ';
      pixel[2,3]=' ';
      pixel[2,4]='_';
      pixel[2,5]=' '; 
      pixel[2,6]=' ';
      pixel[2,7]=' ';
      pixel[2,8]=' ';
      pixel[2,9]='_';
      pixel[2,10]=' '; 
      pixel[2,11]='_';
      pixel[2,12]='\\';
      pixel[3,0]='=';
      pixel[3,1]='\'';
      pixel[3,2]='-'; 
      pixel[3,3]='(';
      pixel[3,4]='_';
      pixel[3,5]=')';
      pixel[3,6]='-';
      pixel[3,7]='-';
      pixel[3,8]='(';
      pixel[3,9]='_';
      pixel[3,10]=')';
      pixel[3,11]='-';
      pixel[3,12]='\''; 
      return pixel;
  }
}