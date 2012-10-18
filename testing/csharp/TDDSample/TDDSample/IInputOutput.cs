namespace TDDSample
{
  public interface IInputOutput
  {
    void WriteLine(string message, params object[] options);
    void Write(string message);
    string ReadLine();
  }
}