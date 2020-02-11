using System;
using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityService
    {
        private IActivityRepository _activityRepo;
        private IActivityTypeRepository _activityTypeRepo;

        public ActivityService(IActivityRepository activityRepo, IActivityTypeRepository activityTypeRepo)
        {
            _activityRepo = activityRepo;
            _activityTypeRepo = activityTypeRepo;
        }

        public Activity Add(Activity Activity)
        {
            var activityType = _activityTypeRepo.Get(Activity.ActivityTypeId);
            if (activityType.RecordType == RecordType.DurationAndDistance
                && Activity.Distance <= 0)
            {
                throw new ApplicationException("You must supply a Distance for this activity.");
            }
            _activityRepo.Add(Activity);
            return Activity;
        }

        public Activity Get(int id)
        {
            return _activityRepo.Get(id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }

        public Activity Update(Activity updatedActivity)
        {
            var Activity = _activityRepo.Update(updatedActivity);
            return Activity;
        }

        public void Remove(Activity Activity)
        {
            _activityRepo.Remove(Activity);
        }

    }
}