
namespace Lession4
{
	/// <summary>
	/// Создаем абстрактный класс, он будет базовым для последующих действий
	/// </summary>
	public abstract class Shape2D
	{
		/// <summary>
		/// Общее свойство для всех наследников - не абстрактное
		/// </summary>
		public string Paper { get { return "Белой бумаге"; } }

		/// <summary>
		/// Полиморфизм - переопределяем название фигуры в каждом 
		/// классе-наследнике
		/// Свойство возвращает имя
		/// </summary>
		public abstract string Name { get; }

		/// <summary>
		/// Определяем абстрактные МЕТОДы.
		/// Обязательно переопределяем его в классах - наследниках
		/// </summary>
		public abstract void Draw();

		/// <summary>
		/// Площадь фигуры
		/// </summary>
		public abstract void Square();

		/// <summary>
		/// Периметр фигуры
		/// </summary>
		//public abstract float Perimeter();

	}
}
