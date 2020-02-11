using System;
using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityTypeService : IActivityTypeService
    {
        private IActivityTypeRepository _activityTypeRepo;

        public ActivityTypeService(IActivityTypeRepository ActivityTypeRepo)
        {
            _activityTypeRepo = ActivityTypeRepo;
        }

        public ActivityType Add(ActivityType ActivityType)
        {
            _activityTypeRepo.Add(ActivityType);
            return ActivityType;
        }

        public ActivityType Get(int id)
        {
            return _activityTypeRepo.Get(id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _activityTypeRepo.GetAll();
        }

        public ActivityType Update(ActivityType updatedActivityType)
        {
            var ActivityType = _activityTypeRepo.Update(updatedActivityType);
            return ActivityType;
        }

        public void Remove(ActivityType ActivityType)
        {
            _activityTypeRepo.Remove(ActivityType);
        }

    }

}
