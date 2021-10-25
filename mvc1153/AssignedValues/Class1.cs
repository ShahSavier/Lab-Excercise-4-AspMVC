using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1153.AssignedValues
{
    /* Namas asal PosLaju adaalah Class1*/
    public class PosLaju
    {
        public string[] weightCategories =
        {
            /* Just using for label not calculation*/
            "< 0.50 kg", "< 0.75 kg", "< 1.00 kg", "< 1.25 kg",
            "< 1.50 kg", "< 1.75kg", "< 2.00 kg", "< 2.50 kg",
            "< 3.00 kg"
        };

        public string[] zones =
        {
            "West Malaysia", "Sarawak" ,"Sabah"
        };

        public double[,] rates = /*2 dimensional array*/
        {
            { 6100 , 8.50, 9.00 },
            { 7.00, 10.50, 12.00 },
            { 8.50, 12.50, 14.50 },
            { 10.00, 14.50, 17.00 },
            { 11.00, 16.50, 20.00 },
            { 12.50, 18.50, 22.50 },
            { 14.00, 20.50, 25.00 },
            { 21.00, 34.50, 41.00 },
            { 24.00, 39.00, 46.00 }
        };
    }
    // Jagged Array 1 Dimensional
    public class SoftwareHouse
    {
        //one dimensional array string & jagged array
        public string[] employees = { "Sarah", "Hafiz", "Amin" };

        //jagged array part
        public string[][] skills =
        {
            new string[]{"C#", "VB", "Java", "PHP"}, //Skills set for sarah
            new string[]{"Python", "R"}, // Skills for Hafiz
            new string[]{"React", "Ionic", "Flutter"} // skills for Amin
        };
    }

    //Jagged Array 2 Dimensional
    public class CourseGrade
    {
        public string[] students = { "Sarah", "Hafiz", "Amin" };

        public string[][,] courses =
        {
            new string[,]{ //represent marks for Sarah "First row"
                {"C#", "A"/*(index 0)*/}, { "VB", "B+"/*(index 1)*/},
                {"Java","B"/*(index 2)*/}, {"PHP", "A-"/*(index 3)*/}},

            new string[,] { //represent marks for Hafiz "Second row"
                {"Python", "B"/*(Index 0)*/},{"R","A-"/*(Index 1)*/}},

            new string[,]
            {
                {"React","C+"/*(Index 0)*/},{"Ionic","B"/*(Index 1)*/},
                {"Flutter","A"/*(Index 2)*/}
            }
        };
    }
}
