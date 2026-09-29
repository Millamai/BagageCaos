using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagageKaos.Model
{
    /// <summary>
    /// This class represents a luggage in an airport
    /// </summary>
    public class Suitcase
    {

        //All suitcase need a unique tagnumber, notice that this is a shared resource - it's static!
        static int tagcounter = 100000;

        /// <summary>
        /// A timestamp for when the luggage has been created
        /// Set property is hidden, since no one is allowed changing this due to integrity
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// IATA code from where the suitcase is departuring from
        /// </summary>
        public string SourceAirport { get; private set; }

        /// <summary>
        /// IATA code for where the suitcase is going
        /// </summary>
        public string DestinationAirport { get; private set; }

        /// <summary>
        /// Unique tagnumber
        /// </summary>
        public int TagNumber { get; private set; }


        /// <summary>
        /// Constructor - The time for when the suicase is created is automatically set and so is the unique tagnumber
        /// </summary>
        /// <param name="sourceAirport">IATA code from where det suitcase is leaving from</param>
        /// <param name="destinationAirport">IATA code for the airport the suitcase is heading towards</param>
        public Suitcase(string sourceAirport, string destinationAirport)
        {
            SourceAirport = sourceAirport;
            DestinationAirport = destinationAirport;
            TagNumber = tagcounter++;
            Created = DateTime.Now;
        }


        public override string ToString()
        {
            return "Suicase number:" + TagNumber + " : Created: " + Created.ToString("HH:MM:ss:ff") + ": From: " + SourceAirport + ": Destination:" + DestinationAirport;
        }

    }
}
