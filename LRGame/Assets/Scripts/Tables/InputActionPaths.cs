using UnityEngine;

public static class InputActionPaths
{
  public class Keyboard
  {
    public const string Q = "<Keyboard>/q";
    public const string W = "<Keyboard>/w";
    public const string E = "<Keyboard>/e";
    public const string R = "<Keyboard>/r";
    public const string T = "<Keyboard>/t";
    public const string Y = "<Keyboard>/y";
    public const string U = "<Keyboard>/u";
    public const string I = "<Keyboard>/i";
    public const string O = "<Keyboard>/o";
    public const string P = "<Keyboard>/p";
    public const string A = "<Keyboard>/a";
    public const string S = "<Keyboard>/s";
    public const string D = "<Keyboard>/d";
    public const string F = "<Keyboard>/f";
    public const string G = "<Keyboard>/g";
    public const string H = "<Keyboard>/h";
    public const string J = "<Keyboard>/j";
    public const string K = "<Keyboard>/k";
    public const string L = "<Keyboard>/l";
    public const string Z = "<Keyboard>/z";
    public const string X = "<Keyboard>/x";
    public const string C = "<Keyboard>/c";
    public const string V = "<Keyboard>/v";
    public const string B = "<Keyboard>/b";
    public const string N = "<Keyboard>/n";
    public const string M = "<Keyboard>/m";

    public const string Escape = "<Keyboard>/escape";
    public const string Space = "<Keyboard>/space";
    public const string Enter = "<Keyboard>/enter";

    public const string Up = "<Keyboard>/upArrow";
    public const string Right = "<Keyboard>/rightArrow";
    public const string Down = "<Keyboard>/downArrow";
    public const string Left = "<Keyboard>/leftArrow";
  }

  public static string ParshPath(KeyCode keyCode)
    => keyCode switch
    {
       KeyCode.Q => Keyboard.Q,
      KeyCode.W => Keyboard.W,
      KeyCode.E => Keyboard.E,
      KeyCode.R => Keyboard.R,
      KeyCode.T => Keyboard.T,
      KeyCode.Y => Keyboard.Y,
      KeyCode.U => Keyboard.U,
      KeyCode.I => Keyboard.I,
      KeyCode.O => Keyboard.O,
      KeyCode.P => Keyboard.P,
      KeyCode.A => Keyboard.A,
      KeyCode.S => Keyboard.S,
      KeyCode.D => Keyboard.D,
      KeyCode.F => Keyboard.F,
      KeyCode.G => Keyboard.G,
      KeyCode.H => Keyboard.H,
      KeyCode.J => Keyboard.J,
      KeyCode.K => Keyboard.K,
      KeyCode.L => Keyboard.L,
      KeyCode.Z => Keyboard.Z,
      KeyCode.X => Keyboard.X,
      KeyCode.C => Keyboard.C,
      KeyCode.V => Keyboard.V,
      KeyCode.B => Keyboard.B,
      KeyCode.N => Keyboard.N,
      KeyCode.M => Keyboard.M,

      KeyCode.Escape => Keyboard.Escape,
      KeyCode.Space => Keyboard.Space,
      KeyCode.Return => Keyboard.Enter,

      KeyCode.UpArrow => Keyboard.Up,
      KeyCode.DownArrow => Keyboard.Down,
      KeyCode.LeftArrow => Keyboard.Left,
      KeyCode.RightArrow => Keyboard.Right,

      _=>throw new System.NotImplementedException(),
    };
}
