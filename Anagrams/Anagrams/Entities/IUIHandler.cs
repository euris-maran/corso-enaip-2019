namespace Anagrams.Entities {
	public interface IUIHandler {
		IRepository WordRepository { get; }
		string AskForString();
		void WriteMessage(string message);
		void Run();
	}
}