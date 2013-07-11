namespace CodeFormatting
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.location = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int eventByDate = this.date.CompareTo(other.date);
            int eventByTitle = this.title.CompareTo(other.title);

            int eventByLocation = this.location.CompareTo(other.location);
            if (eventByDate == 0)
            {
                if (eventByTitle == 0)
                {
                    return eventByLocation;
                }
                else
                {
                    return eventByTitle;
                }
            }
            else
            {
                return eventByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (!string.IsNullOrEmpty(this.location))
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
