using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    public class Entrant
    {
        private double payForMonth;
        private double payForYear;
        private double payForWholePeriod;
        private string name;
        private string idNum;
        private double coursePoints;
        private double avgPoints;
        private ZNO[] znoResults;

        public string Name { get => name; set => name = value; }
        public string IdNum { get => idNum; set => idNum = value; }
        public double CoursePoints { get => coursePoints; set => coursePoints = value; }
        public double AvgPoints { get => avgPoints; set => avgPoints = value; }
        public ZNO[] ZNOResults { get => znoResults; set => znoResults = value; }
        public double PayForMonth { get => payForMonth; set => payForMonth = value; }
        public double PayForYear { get => payForYear; set => payForYear = value; }
        public double PayForWholePeriod { get => payForWholePeriod; set => payForWholePeriod = value; }

        public Entrant(string name, string idNum, double coursePoints, double avgPoints, ZNO[] znoResults, double payForMonth, double payForYear, double payForWholePeriod)
        {
            Name = name;
            IdNum = idNum;
            CoursePoints = coursePoints;
            AvgPoints = avgPoints;
            ZNOResults = znoResults;
            PayForMonth = payForMonth;
            PayForYear = payForYear;
            PayForWholePeriod = payForWholePeriod;
        }

        public Entrant()
        {
            Name = "";
            IdNum = "";
            CoursePoints = 0;
            AvgPoints = 0;
            ZNOResults = new ZNO[0];
            PayForMonth = 0;
            PayForYear = 0;
            PayForWholePeriod = 0;
        }

        public Entrant(Entrant entrant)
        {
            Name = entrant.Name;
            IdNum = entrant.IdNum;
            CoursePoints = entrant.CoursePoints;
            AvgPoints = entrant.AvgPoints;
            ZNOResults = entrant.ZNOResults;
            PayForMonth = entrant.PayForMonth;
            PayForYear = entrant.PayForYear;
            PayForWholePeriod = entrant.PayForWholePeriod;
        }

        public double GetCompMark()
        {
            double compMark = CoursePoints * 0.05 + AvgPoints * 0.10;
            if (ZNOResults.Length < 3)
                return 0;
            Array.Sort(ZNOResults, (x, y) => y.Points.CompareTo(x.Points));

            for (int i = 0; i < 3; i++)
            {
                compMark += ZNOResults[i].Points * (i == 0 ? 0.25 : i == 1 ? 0.40 : 0.20);
            }
            return compMark;
        }

        public string GetBestSubject()
        {
            if (ZNOResults.Length == 0)
                return "";
            var bestSubject = ZNOResults.OrderByDescending(zno => zno.Points).First();
            return bestSubject.Subject;
        }

        public string GetWorstSubject()
        {
            if (ZNOResults.Length == 0)
                return "";
            var worstSubject = ZNOResults.OrderBy(zno => zno.Points).First();
            return worstSubject.Subject;
        }

    }
}
