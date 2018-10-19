using System.ComponentModel;
using System.Runtime.CompilerServices;
using Moving_Points.Annotations;

namespace Moving_Points.Models {
    public class Point : INotifyPropertyChanged {
        private double x;
        private double y;

        public Point(double x, double y) {
            X = x;
            Y = y;
        }

        public double X {
            get => x;
            set {
                x = value;
                OnPropertyChanged(nameof(X));
            }
        }


        public double Y {
            get => y;
            set {
                y = value;
                OnPropertyChanged(nameof(Y));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}