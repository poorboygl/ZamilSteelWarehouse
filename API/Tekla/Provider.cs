using System;
using System.Collections.Generic;
using System.Text;
using Tekla.Structures.Model;

namespace API.Tekla
{

    public class Provider
    {
        Model MyModel;
       public Provider(Model mymodel)
        {
            this.MyModel = mymodel;
        }

        ContourPlateRepository contourPlateRepository;
        public ContourPlateRepository ContourPlateRepository
        {
            get
            {
                if (contourPlateRepository is null)
                {
                    contourPlateRepository = new ContourPlateRepository(MyModel);
                }
                return contourPlateRepository;
            }
        }
        AssemblyRepository assemblyRepository;
        public AssemblyRepository AssemblyRepository
        {
            get
            {
                if (assemblyRepository is null)
                {
                    assemblyRepository = new AssemblyRepository(MyModel);
                }
                return assemblyRepository;
            }
        }
        GridRepository gridRepository;
        public GridRepository GridRepository
        {
            get
            {
                if (gridRepository is null)
                {
                    gridRepository = new GridRepository(MyModel);
                }
                return gridRepository;
            }
        }
        RebarRepository rebarRepository;
        public RebarRepository RebarRepository
        {
            get
            {
                if (rebarRepository is null)
                {
                    rebarRepository = new RebarRepository(MyModel);
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
                    footingRepository = new FootingRepository(MyModel);
                }
                return footingRepository;
            }
        }
        BeamRepository beamRepository;
        public BeamRepository BeamRepository
        {
            get
            {
                if (beamRepository is null)
                {
                    beamRepository = new BeamRepository(MyModel);
                }
                return beamRepository;
            }
        }
        BasePlateRepository baseplateRepository;
        public BasePlateRepository BaseplateRepository
        {
            get
            {
                if (baseplateRepository is null)
                {
                    baseplateRepository = new BasePlateRepository(MyModel);
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
                    userInteraction = new UserInteraction(MyModel);
                }
                return userInteraction;
            }
        }
    }
}
