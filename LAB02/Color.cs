using System;

namespace LAB02
{
  class Color{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public int Red { 
      get => red; 
      set {
        if(value >=0  && value <= 255)
          red=value;
        else 
          throw new Exception("Value between 0 - 255");
      }
    }
    public int Green { 
      get => green; 
      set {
        if(value >=0  && value <= 255)
          green=value;
        else 
          throw new Exception("Value between 0 - 255");
      }
    }
    public int Blue { 
      get => blue; 
      set {
        if(value >=0  && value <= 255)
          blue=value;
        else 
          throw new Exception("Value between 0 - 255");
      }
    }
    public int Alpha { 
      get => alpha; 
      set {
        if(value >=0  && value <= 255)
          alpha=value;
        else 
          throw new Exception("Value between 0 - 255");
      }
    }


    public Color(){
      this.red=255;
      this.blue=255;
      this.green=255;
      this.alpha=255;
    }

    public Color(int red, int green, int blue, int alpha)
    {
      this.red = red;
      this.green = green;
      this.blue = blue;
      this.alpha = alpha;
    }

    public Color(Color color){
      this.red = color.red;
      this.green = color.green;
      this.blue = color.blue;
      this.alpha = color.alpha;
    }

    public int GetGrayScale() => (Red + Green + Blue) / 3;

    public override string ToString()
    {
      return "Red : "  + red + "\n" 
            + "Green : " + green + "\n"
            + "Blue : " + blue + "\n"
            + "Alpha : "+ alpha + "\n";
    }
  }
}
