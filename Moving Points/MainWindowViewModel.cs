using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using Moving_Points.Models;

namespace Moving_Points {
    public class MainWindowViewModel {
        private readonly Random random = new Random();
        private readonly DispatcherTimer timer = new DispatcherTimer();

        public MainWindowViewModel() {
            Lines = new ObservableCollection<Line>();

            Line line1 = new Line(new Point(100, 100), new Point(100, 150));
            Lines.Add(line1);
            Line line2 = new Line(new Point(150, 100), new Point(100, 105));
            Lines.Add(line2);
            Line line3 = new Line(new Point(70, 30), new Point(80, 200));
            Lines.Add(line3);
            Line line4 = new Line(new Point(103, 100), new Point(10, 150));
            Lines.Add(line4);
            Line line5 = new Line(new Point(100, 108), new Point(90, 105));
            Lines.Add(line5);

            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += (sender, args) => {
                foreach (Line line in Lines) {
                    line.A.X += GiveMeNext();
                    line.B.X += GiveMeNext();
                    line.A.Y += GiveMeNext();
                    line.B.Y += GiveMeNext();
                }
            };

            timer.Start();
        }

        public ObservableCollection<Line> Lines { get; set; }

        private int GiveMeNext() {
            return random.Next(-10, 15);
        }
    }
}