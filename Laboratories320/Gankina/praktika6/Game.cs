using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Gankina.praktika6
{
    class Game
	{
		string userName;
		DateTime dayOfBirth;
		int finishedMatch;
		int vicroties;
		double gamePoint;
		List<Game> game = new List<Game> { };


		public string UserName { get => userName; set => userName = value; }
		public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
		public int FinishedMatch { get => finishedMatch; set => finishedMatch = value; }
		public int Vicroties { get => vicroties; set => vicroties = value; }
		public double GamePoint { get => gamePoint; set => gamePoint = value; }

		public Game(string userName, DateTime dayOfBirth, int finishedMatch, int victories, double gamePoint)
		{
			UserName = userName;
			DayOfBirth = dayOfBirth;
			FinishedMatch = finishedMatch;
			Vicroties = victories;
			GamePoint = gamePoint;
			game.Add(this);
		}

		public void SearchByName(string nameUser)
		{
			Parallel.ForEach(game, item =>
			{
				if (item.UserName == nameUser)
				{
					{
						Console.WriteLine($"Информация о пользователе:\n{userName}\n" +
							$"Дата рождения: {dayOfBirth}");
					}
					

				}

			});

	
			}
		}
	}



