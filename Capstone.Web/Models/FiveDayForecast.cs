﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Models
{
    public class FiveDayForecast
    {
        private List<Forecast> fiveDayForecast = new List<Forecast>();
        public bool IsFarenheit { get; set; }

        private IWeatherDAL dal;
        public FiveDayForecast(IWeatherDAL dal, string id)
        {
            this.dal = dal;
            fiveDayForecast = dal.GetForecast(id);
        }
        public List<Forecast> GetForecast()
        {
            return fiveDayForecast;
        }
        public string GetId()
        {
            string id = "";
            foreach(Forecast forecast in fiveDayForecast)
            {
                id = forecast.ParkCode;
            }
            return id;
        }
    }
}     


        //private IWeatherDAL dal;
        //public FiveDayForecast(IWeatherDAL dal, string id)
        //{
        //    this.dal = dal;
        //    this.id = id;
        //}
        ////Park park = new Park();
        ////WeatherSqlDAL dal = new WeatherSqlDAL(@"Data Source =.\SQLEXPRESS; Initial Catalog = npgeek; User ID = te_student; Password=sqlserver1");

        //public string id;

        //public List<Forecast> GetForecast()
        //{
        //    List<Forecast> forecast = new List<Forecast>();
        //    forecast = dal.GetForecast(id);
        //    return forecast;
        //}
        //public bool isFarenheit = true;

        //}