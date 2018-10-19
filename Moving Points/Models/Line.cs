using System.ComponentModel;
using System.Runtime.CompilerServices;
using Moving_Points.Annotations;

namespace Moving_Points.Models {
    public class Line : INotifyPropertyChanged {
        private Point a;
        private Point b;

        public Line(Point a, Point b) {
            A = a;
            B = b;
        }

        public Point A {
            get => a;
            set {
                a = value;
                OnPropertyChanged(nameof(A));
            }
        }

        public Point B {
            get => b;
            set {
                b = value;
                OnPropertyChanged(nameof(B));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}