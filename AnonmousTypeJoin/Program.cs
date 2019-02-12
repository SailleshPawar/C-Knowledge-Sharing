using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AnonmousTypeJoin
{
    public class MeetingMaster
    {
        public int MOMId
        {
            get;
            set;
        }
        public int SegmentId
        {
            get;
            set;
        }
        public int MeetingNameId
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }

    }
    public class MeetingNameMaster
    {
        public int Id
        {
            get;
            set;
        }
        public string MeetingName
        {
            get;
            set;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var meetingList = new List<MeetingNameMaster>
                {
                new MeetingNameMaster
                {
                        Id = 1,
                        MeetingName = "RMS"
                },
                new MeetingNameMaster
                {
                    Id = 2,
                        MeetingName = "Functional"
                },
                new MeetingNameMaster
                {
                    Id = 3,
                        MeetingName = "Hr"
                }

            };

            var meetingMaster = new List<MeetingMaster>
                {
                new MeetingMaster
                {
                        MOMId = 1,
                        MeetingNameId = 1,
                        Description = "RMS Funtional covered",
                        SegmentId = 1
                },
                new MeetingMaster
                {
                       MOMId = 2,
                        MeetingNameId = 1,
                        Description = "Functional Agenda Covered"


                },
                new MeetingMaster
                {

                    MOMId = 3,
                        MeetingNameId = 1,
                        Description = "Rms functional covered responsibility taken by saillesh pawar",
                        SegmentId = 1


                }
            };

            var rmsMeetingCommenced = (from mtnMaster in meetingMaster
                                       join meetings
                                        in meetingList 
                                        on mtnMaster.MeetingNameId equals meetings.Id
                                       select new
                                       {
                                           MOMId = mtnMaster.MOMId,
                                           Desciption = mtnMaster.Description,
                                           MeetingName = meetings.MeetingName
                                       }).ToList();


            ////
            ///select source.momId,source2.description 
            ///form meetingMaster source
            ///inner join meetingList source2
            ///on source
            ///inner join meetingList.MeetingNameId=source2.Id
            ///
            



            foreach (var i in rmsMeetingCommenced)
            {
                WriteLine($@"The MOM id is { i.MOMId}  MeetingId is {i.MeetingName}  Meeting Description is={i.Desciption} MeetingNameMeetingName is ={i.MeetingName}");

            }

            ReadLine();
        }
    }
}
