﻿using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class WorkoutTypeRepository
    {
        private static List<WorkoutType> workoutTypes = new();
        private static readonly object workoutTypeSyncLock = new();

        #region Insert WorkoutType
        public static WorkoutType Save(WorkoutType workoutType)
        {
            workoutTypes.Add(workoutType);
            return workoutType;
        }
        #endregion

        #region Get All WorkoutTypes
        public static List<WorkoutType> GetALL()
        {
            return workoutTypes.Where(u => u.Status == Enum.CommonStatusEnum.ACTIVE).ToList();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (workoutTypeSyncLock)
            {
                long newWorkoutTypeId = 1;

                if (!workoutTypes.Any())
                {
                    return newWorkoutTypeId;
                }

                WorkoutType workoutTypeWithMaxId = workoutTypes.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (workoutTypeWithMaxId != null)
                {
                    newWorkoutTypeId = workoutTypeWithMaxId.Id + 1;
                }

                return newWorkoutTypeId;
            }
        }
    }
}