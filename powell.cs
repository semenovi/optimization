using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution
{
	class powell
	{
		// допустимый интервал неопределенности
		public double eps;
		// количество линейно независимых уравнений
		public int k;
		// минимум одномерной функции
		public double t;
		// количество измерений
		public int n;
		// шаг
		public int i;
		// точки y, направления d, начальные точки
		public double[] y_0, y_1, d_0, d_1, x_0, x_1;
		// интервал одномерной функции
		public double a, b;
		// решение
		public double x0min, x1min;

		// функция
		public double f(double _y0, double _y1, double _t, double _d0, double _d1)
		{
			double x1 = _y0 + _t * _d0;
			double x2 = _y1 + _t * _d1;
			return (2 * Math.Pow(x1, 2) + x1 * x2 + Math.Pow(x2, 2));
		}
		// функция для нахождения одномерного минимума
		public double one_dimension_f(double x)
		{
			return (f(y_0[i], y_1[i], x, d_0[i], d_1[i]));
		}
		public powell(double _x0, double _x1, double _eps, double _d10, double _d11, double _d20, double _d21)
		{
			eps = _eps;
			n = 2;
			y_0 = new double[n + 8];
			y_1 = new double[n + 8];
			d_0 = new double[n + 8];
			d_1 = new double[n + 8];
			x_0 = new double[n + 8];
			x_1 = new double[n + 8];
			d_0[1] = _d10;
			d_1[1] = _d11;
			d_1[2] = _d20;
			d_1[2] = _d21;
			x_0[0] = _x0;
			x_1[0] = _x1;
		}
		public void swann_define_interval()
		{
			double x0 = 1, t = 1;
			double f_x0_minus_t = 0, f_x0 = 0, f_x0_plus_t = 0;
			double delta = 0;
			double x = 0;
			double xk1 = 0;
			int k = 0;
			f_x0_minus_t = one_dimension_f(x0 - t);
			f_x0 = one_dimension_f(x0);
			f_x0_plus_t = one_dimension_f(x0 + t);
			while(true)
			{
				// проверить условие окончания
				if (f_x0_minus_t >= f_x0 && f_x0_plus_t >= f_x0)
				{
					a = f_x0_minus_t;
					b = f_x0_plus_t;
					return;
				}
				else if (f_x0_minus_t <= f_x0 && f_x0_plus_t <= f_x0)
				{
					x0++;
					continue;
				}
				else
				{
					// определить величину delta
					if (f_x0_minus_t >= f_x0 && f_x0_plus_t <= f_x0)
					{
						delta = t;
						a = x0;
						x = x0 + t;
						k = 1;
					}
					else if (f_x0_minus_t <= f_x0 && f_x0_plus_t >= f_x0)
					{
						delta = -t;
						b = x0;
						x = x0 - t;
						k = 1;
					}
				}
				while (true)
				{
					// найти следующую точку x
					xk1 = x + Math.Pow(2, k) * delta;
					if (one_dimension_f(xk1) < one_dimension_f(x) && delta == t)
					{
						a = x;
						x = xk1;
						k++;
					}
					else if (one_dimension_f(xk1) < one_dimension_f(x) && delta == -t)
					{
						b = x;
						x = xk1;
						k++;
					}
					else
					{
						if (delta == t)
						{
							b = xk1;
							return;
						}
						else
						{
							a = xk1;
							return;
						}
					}
				}
			}
		}
		public int fibonacci(int n)
		{
			// формула Бине
			double phi = (1 + Math.Sqrt(5)) / 2;
			return Convert.ToInt32((Math.Pow(phi, n) - Math.Pow(-phi, -n)) / (2 * phi - 1));
		}
		public void fibonacci_min()
		{
			// интервал неопределенности
			swann_define_interval();
			// константа различимости
			double delta = 0.01;
			// число вычислений функции
			int N = Convert.ToInt32((b - a) / eps);
			int S = 1;
			while (N > fibonacci(S + 1))
				S++;
			// счетчик
			int k = 1;
			// конечный интервал неопределенности
			double l = (b - a) / fibonacci(S);
			// решения
			double x1 = a + l * fibonacci(S - 2);
			double x2 = b - l * fibonacci(S - 2);
			// значение функции в решениях
			double A = one_dimension_f(x1);
			double B = one_dimension_f(x2);
			while (true)
			{
				if (A < B)
				{
					b = x2;
					k++;
					if (k == S - 1)
					{
						x2 = x1 + delta;
						B = one_dimension_f(x2);
						break;
					}
					else
					{
						x2 = x1;
						B = A;
						x1 = a + l * fibonacci(S - 1 - k);
						A = one_dimension_f(x1);
					}
				}
				else
				{
					a = x1;
					k++;
					if (k == S - 1)
					{
						x2 = x1 + delta;
						B = one_dimension_f(x2);
						break;
					}
					else
					{
						x1 = x2;
						A = B;
						x2 = b - l * fibonacci(S - 1 - k);
						B = one_dimension_f(x2);
					}
				}
			}
			if (A < B)
			{
				b = x1;
			}
			else
			{
				a = x1;
			}
			t = (a + b) / 2;
		}
		private int rank(double[,] matrix)
		{
			if (matrix[1, 0] != 0)
				for (int i = 1; i < 2; i++)
				{
					double multiplier = (matrix[0, 0] / matrix[i, 0]) * (-1);
					for (int j = 0; j < 2; j++)
					{
						matrix[i, j] = matrix[i, j] * multiplier + matrix[i - 1, j];
					}
				}
			int k;
			int y = 0;
			for (int i = 0; i < 2; i++)
			{
				k = 0;
				for (int j = 0; j < 2; j++)
				{
					if (matrix[i, j] == 0)
						k++;
				}
				if (k == 2)
					y++;
			}
			int rang = 2 - y;
			return rang;
		}
		public void calculate()
		{
			d_0[0] = d_0[n];
			d_1[0] = d_1[n];
			y_0[0] = x_0[0];
			y_1[0] = x_1[0];
			k = 0;
			while (true)
			{
				fibonacci_min();
				//t = Math.Round(t);
				y_0[i + 1] = y_0[i] + t * d_0[i];
				y_1[i + 1] = y_1[i] + t * d_1[i];
				if (i < n - 1)
				{
					i++;
					continue;
				}
				else if (i == n - 1)
				{
					if (y_0[n] == y_0[0] && y_1[n] == y_1[0])
					{
						x0min = y_0[n];
						x1min = y_1[n];
						break;
					}
					else
					{
						i++;
					}
				}
				else // i == n
				{
					if (y_0[n + 1] == y_0[0] && y_1[n + 1] == y_1[0])
					{
						x0min = y_0[n + 1];
						x1min = y_1[n + 1];
						break;
					}
					else
					{
						x_0[k + 1] = y_0[n + 1];
						x_1[k + 1] = y_1[n + 1];
						if (Math.Sqrt(Math.Pow(x_0[k + 1] - x_0[k], 2) + Math.Pow(x_1[k + 1] - x_1[k], 2)) < eps)
						{
							x0min = x_0[k + 1];
							x1min = x_1[k + 1];
							break;
						}
						else
						{
							double[] d_0_ = new double[n + 1];
							double[] d_1_ = new double[n + 1];
							// выбрать новое направление
							d_0_[0] = y_0[n + 1] - y_0[1];
							d_1_[0] = y_1[n + 1] - y_1[1];
							d_0_[n] = d_0_[0];
							d_1_[n] = d_1_[0];
							// исключить старое направление
							for (int i = 1; i < n; i++)
							{
								d_0_[i] = d_0[i + 1];
								d_1_[i] = d_1[i + 1];
							}
							double[,] matrix = new double[n, n];
							matrix[0, 0] = d_0_[0];
							matrix[0, 1] = d_0_[n - 1];
							matrix[1, 0] = d_1_[0];
							matrix[1, 1] = d_1_[n - 1];
							if (rank(matrix) == n)
							{
								for (int i = 0; i <= n; i++)
								{
									d_0[i] = d_0_[i];
									d_1[i] = d_1_[i];
								}
							}
							y_0[0] = x_0[k + 1];
							y_1[0] = x_1[k + 1];
							k++;
							i = 0;
						}
					}
				}
			}
			// выбрасываем все что больше e
			int digits_count = Convert.ToInt32(Math.Log10(1 / eps));
			x0min = Math.Round(x0min, digits_count);
			x1min = Math.Round(x1min, digits_count);
		}
	}
}
