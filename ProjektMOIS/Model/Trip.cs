

using System;
using ProjektMOIS.Model;

namespace ProjektMOIS.Model
{
    public class Trip : AbstractEntity
    {
        
        public virtual String Destination { get; set; }
        public virtual int Length { get; set; }
        public virtual int RoomSize { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual DateTime DateEnd { get; set; }
        public virtual String Description { get; set; }
        public virtual String Category { get; set; }
        public virtual String Meals { get; set; }
        public virtual int Stars { get; set; }
        public virtual float Prize { get; set; }
        public virtual String TripType { get; set; }
        public virtual String TransferType { get; set; }
        public virtual String AccommodationType { get; set; }

    }
}