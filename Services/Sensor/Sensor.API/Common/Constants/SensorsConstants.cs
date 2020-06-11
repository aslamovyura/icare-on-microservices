﻿namespace Sensor.API.Common.Constants
{
    /// <summary>
    /// Sensor common constants.
    /// </summary>
    public static class SensorsConstants
    {
        /// <summary>
        /// Sensor already exists.
        /// </summary>
        public static string SENSOR_ALREADY_EXIST { get; set; } = "Sensor already exists!";

        /// <summary>
        /// Unknown sensor type.
        /// </summary>
        public static string UNKNOWN_SENSOR_TYPE { get; set; } = "Unknown sensor type!";

        /// <summary>
        /// Unknown sensor serial number.
        /// </summary>
        public static string UNKNOWN_SENSOR_SERIAL { get; set; } = "Unknown sensor serial number!";

        /// <summary>
        /// Sensor not found.
        /// </summary>
        public static string SENSOR_NOT_FOUND { get; set; } = "Sensor not found!";

        /// <summary>
        /// Sensor not found.
        /// </summary>
        public static string GET_FOUND_SENSOR { get; set; } = "Sensor found.";

        /// <summary>
        /// Sensor recieved.
        /// </summary>
        public static string GET_SENSORS { get; set; } = "Sensors recieved.";

        /// <summary>
        /// Sensor registration conflict.
        /// </summary>
        public static string ADD_SENSOR_CONFLICT { get; set; } = "New sensor registration conflict!";

        /// <summary>
        /// New sensor was successfully registered.
        /// </summary>
        public static string ADD_SENSOR_SUCCESS { get; set; } = "New sensor was successfullty registered!";

        /// <summary>
        /// Sensor update conflict.
        /// </summary>
        public static string UPDATE_SENSOR_CONFLICT { get; set; } = "Sensor update conflict!";

        /// <summary>
        /// Sensor update success.
        /// </summary>
        public static string UPDATE_SENSOR_SUCCESS { get; set; } = "Sensor update success!";

        /// <summary>
        /// Sensor deletion conflict.
        /// </summary>
        public static string DELETE_SENSOR_CONFLICT { get; set; } = "Sensor deletion conflict!";

        /// <summary>
        /// Sensor deletion success.
        /// </summary>
        public static string DELETE_SENSOR_SUCCESS { get; set; } = "Sensor deletion success!";
    }
}