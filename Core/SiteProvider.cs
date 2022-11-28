using System;
using System.Collections.Generic;
using System.Text;
using Tekla.Structures.Model;

namespace StartUp
{

    class SiteProvider
    {
        Model model = TeklaConnection.Model;
        RebarRepository rebarRepository;
        //InputData data;
        //public InputData Data
        //{
        //    get
        //    {
        //        if (data is null)
        //        {
        //            data = new InputData();
        //        }
        //        return data;
        //    }
        //}
        public RebarRepository RebarRepository
        {
            get
            {
                if (rebarRepository is null)
                {
                    rebarRepository = new RebarRepository(model);
                }
                return rebarRepository;
            }
        }
        FootingRepository footingRepository;  
        public FootingRepository FootingRepository
        {
            get
            {
                if (footingRepository is null)
                {
                    footingRepository = new FootingRepository(model);
                }
                return footingRepository;
            }
        }
        ColumnRepository columnRepository;
        public ColumnRepository ColumnRepository
        {
            get
            {
                if (columnRepository is null)
                {
                    columnRepository = new ColumnRepository(model);
                }
                return columnRepository;
            }
        }
        BasePlateRepository baseplateRepository;
        public BasePlateRepository BaseplateRepository
        {
            get
            {
                if (baseplateRepository is null)
                {
                    baseplateRepository = new BasePlateRepository(model);
                }
                return baseplateRepository;
            }
        }
        UserInteraction userInteraction;
        public UserInteraction UserInteraction
        {
            get
            {
                if (userInteraction is null)
                {
                    userInteraction = new UserInteraction(model);
                }
                return userInteraction;
            }
        }
    }
}
