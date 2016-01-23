using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using mqlsharp.Util;
using MQL4CSharp.Base.Enums;

namespace MQL4CSharp.Base
{
    public abstract class MQL
    {
        public ILog LOG;

        public MQL()
        {
            LOG = LogManager.GetLogger(GetType());
        }


        /// <summary>
        /// Function: Alert
        /// Description: Displays a message in a separate window.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/alert.html
        /// </summary>
        /// <param name="first value"></param>
        public void Alert (argument first value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(first value);
            
            CommandManager.getInstance().ExecCommand(Command.Alert, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CheckPointer
        /// Description: The function returns the type of the object
        /// URL: http://mm.l/mql4/docs.mql4.com/common/checkpointer.html
        /// </summary>
        /// <param name="*"></param>
        public ENUM_POINTER_TYPE CheckPointer (object *)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(*);
            
            CommandManager.getInstance().ExecCommand(Command.CheckPointer, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (ENUM_POINTER_TYPE) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Comment
        /// Description: This function outputs a comment defined by a user in the top left corner of a chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/comment.html
        /// </summary>
        /// <param name="first value"></param>
        public void Comment (argument first value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(first value);
            
            CommandManager.getInstance().ExecCommand(Command.Comment, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CryptEncode
        /// Description: Transforms the data from array with the specified method.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/cryptencode.html
        /// </summary>
        /// <param name="method">[in] Data transformation method. Can be one of the values of enumeration.</param>
        /// <param name="data[]">[in] Source array.</param>
        /// <param name="key[]">[in] Key array.</param>
        /// <param name="result[]">[out] Destination array.</param>
        public int CryptEncode (ENUM_CRYPT_METHOD method, const uchar& data[], const uchar& key[], uchar& result[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(method);
            parameters.Add(data[]);
            parameters.Add(key[]);
            parameters.Add(result[]);
            
            CommandManager.getInstance().ExecCommand(Command.CryptEncode, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CryptDecode
        /// Description: Performs the inverse transformation of the data from array, tranformed by
        /// URL: http://mm.l/mql4/docs.mql4.com/common/cryptdecode.html
        /// </summary>
        public   (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.CryptDecode, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return () CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: DebugBreak
        /// Description: It is a program breakpoint in debugging.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/debugbreak.html
        /// </summary>
        public void DebugBreak (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.DebugBreak, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ExpertRemove
        /// Description: The function stops an
        /// URL: http://mm.l/mql4/docs.mql4.com/common/expertremove.html
        /// </summary>
        public void ExpertRemove (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ExpertRemove, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GetPointer
        /// Description: The function returns the object
        /// URL: http://mm.l/mql4/docs.mql4.com/common/getpointer.html
        /// </summary>
        /// <param name="anyobject">[in] Object of any class.</param>
        public void* GetPointer (any_class anyobject)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(anyobject);
            
            CommandManager.getInstance().ExecCommand(Command.GetPointer, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void*) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GetTickCount
        /// Description: The GetTickCount() function returns the number of milliseconds that elapsed since the system start.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/gettickcount.html
        /// </summary>
        public uint GetTickCount (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.GetTickCount, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GetMicrosecondCount
        /// Description: The GetMicrosecondCount() function returns the number of microseconds that have elapsed since the start of MQL program.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/getmicrosecondcount.html
        /// </summary>
        public ulong GetMicrosecondCount (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.GetMicrosecondCount, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (ulong) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MessageBox
        /// Description: It creates and shows a message box and manages it. A message box contains a message and header, any combination of predefined signs and command buttons.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/messagebox.html
        /// </summary>
        /// <param name="text">[in] Text, containing message to output.</param>
        /// <param name="caption">[in] Optional text to be displayed in the box header. If the parameter is empty, Expert Advisor name is shown in the box header.</param>
        /// <param name="flags">[in] Optional defining appearance and behavior of a message box. Flags can be a combination of a special group of flags.</param>
        public int MessageBox (string text, string caption, int flags)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text);
            parameters.Add(caption);
            parameters.Add(flags);
            
            CommandManager.getInstance().ExecCommand(Command.MessageBox, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: PeriodSeconds
        /// Description: This function returns number of seconds in a period.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/periodseconds.html
        /// </summary>
        /// <param name="period">[in] Value of a chart period from the enumeration . If the parameter isn't specified, it returns the number of seconds of the current chart period, at which the program runs.</param>
        public int PeriodSeconds (ENUM_TIMEFRAMES period)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(period);
            
            CommandManager.getInstance().ExecCommand(Command.PeriodSeconds, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: PlaySound
        /// Description: It plays a sound file.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/playsound.html
        /// </summary>
        /// <param name="filename">[in] Path to a sound file. If filename=NULL, the playback is stopped.</param>
        public bool PlaySound (string filename)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(filename);
            
            CommandManager.getInstance().ExecCommand(Command.PlaySound, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Print
        /// Description: It enters a message in the Expert Advisor log. Parameters can be of any type.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/print.html
        /// </summary>
        /// <param name="first value"></param>
        public void Print (argument first value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(first value);
            
            CommandManager.getInstance().ExecCommand(Command.Print, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: PrintFormat
        /// Description: It formats and enters sets of symbols and values in the Expert Advisor log in accordance with a preset format.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/printformat.html
        /// </summary>
        /// <param name="format_string">[in] A format string consists of simple symbols, and if the format string is followed by arguments, it also contains format specifications.</param>
        public void PrintFormat (string format_string)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(format_string);
            
            CommandManager.getInstance().ExecCommand(Command.PrintFormat, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ResetLastError
        /// Description: Sets the value of the predefined variable
        /// URL: http://mm.l/mql4/docs.mql4.com/common/resetlasterror.html
        /// </summary>
        public void ResetLastError (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ResetLastError, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ResourceCreate
        /// Description: Creates an image resource based on a data set. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/common/resourcecreate.html
        /// </summary>
        /// <param name="resource_name">[in] Resource name.</param>
        /// <param name="path">[in] Relative path to the file, containing the resource data. If the path is started from "\" (written as "\\"), it is assumed that file path is relative to terminal_data_folder\MQL4\, otherwise it is assumed that file is specified relative to .EX4 program folder.</param>
        public bool ResourceCreate (const string resource_name, const string path)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(resource_name);
            parameters.Add(path);
            
            CommandManager.getInstance().ExecCommand(Command.ResourceCreate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ResourceCreate
        /// Description: Creates an image resource based on a data set. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/common/resourcecreate.html
        /// </summary>
        /// <param name="resource_name">[in] Resource name.</param>
        /// <param name="data[]"></param>
        /// <param name="img_width">[in] The width of the rectangular image area in pixels to be placed in the resource in the form of an image. It cannot be greater than the data_width value.</param>
        /// <param name="img_height">[in] The height of the rectangular image area in pixels to be placed in the resource in the form of an image.</param>
        /// <param name="data_xoffset">[in] The horizontal rightward offset of the rectangular area of the image.</param>
        /// <param name="data_yoffset">[in] The vertical downward offset of the rectangular area of the image.</param>
        /// <param name="data_width">[in] Required only for one-dimensional arrays. It denotes the full width of the image from the data set. If data_width=0, it is assumed to be equal to img_width. For two-dimensional arrays the parameter is ignored and is assumed to be equal to the second dimension of the data[] array.</param>
        /// <param name="color_format">[in] Color processing method, from a value from the enumeration.</param>
        public bool ResourceCreate (const string resource_name, const uint& data[], uint img_width, uint img_height, uint data_xoffset, uint data_yoffset, uint data_width, ENUM_COLOR_FORMAT color_format)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(resource_name);
            parameters.Add(data[]);
            parameters.Add(img_width);
            parameters.Add(img_height);
            parameters.Add(data_xoffset);
            parameters.Add(data_yoffset);
            parameters.Add(data_width);
            parameters.Add(color_format);
            
            CommandManager.getInstance().ExecCommand(Command.ResourceCreate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ResourceFree
        /// Description: The function deletes
        /// URL: http://mm.l/mql4/docs.mql4.com/common/resourcefree.html
        /// </summary>
        /// <param name="resource_name">[in] name should start with "::".</param>
        public bool ResourceFree (const string resource_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(resource_name);
            
            CommandManager.getInstance().ExecCommand(Command.ResourceFree, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ResourceReadImage
        /// Description: The function reads data from the graphical resource
        /// URL: http://mm.l/mql4/docs.mql4.com/common/resourcereadimage.html
        /// </summary>
        /// <param name="resource_name">[in] Name of the graphical resource containing an image. To gain access to its own resources, the name is used in brief form "::resourcename". If we download a resource from a compiled EX4 file, the full name should be used with the path relative to MQL4 directory, file and resource names "path\\filename.ex4::resourcename".</param>
        /// <param name="data[]"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public bool ResourceReadImage (const string resource_name, uint& data[], uint& width, uint& height)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(resource_name);
            parameters.Add(data[]);
            parameters.Add(width);
            parameters.Add(height);
            
            CommandManager.getInstance().ExecCommand(Command.ResourceReadImage, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ResourceSave
        /// Description: Saves a resource into the specified file.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/resourcesave.html
        /// </summary>
        /// <param name="resource_name">[in] The name of the resource, must start with "::".</param>
        /// <param name="file_name">[in] The name of the file relative to MQL4\Files.</param>
        public bool ResourceSave (const string resource_name, const string file_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(resource_name);
            parameters.Add(file_name);
            
            CommandManager.getInstance().ExecCommand(Command.ResourceSave, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetUserError
        /// Description: Sets the predefined variable
        /// URL: http://mm.l/mql4/docs.mql4.com/common/setusererror.html
        /// </summary>
        /// <param name="user_error">[in] number set by a user.</param>
        public void SetUserError (ushort user_error)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(user_error);
            
            CommandManager.getInstance().ExecCommand(Command.SetUserError, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SendFTP
        /// Description: Sends a file at the address, specified in the setting window of the "FTP" tab.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/sendftp.html
        /// </summary>
        /// <param name="filename">[in] Name of sent file.</param>
        /// <param name="ftp_path">[in] FTP catalog. If a directory is not specified, directory described in settings is used.</param>
        public bool SendFTP (string filename, string ftp_path)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(filename);
            parameters.Add(ftp_path);
            
            CommandManager.getInstance().ExecCommand(Command.SendFTP, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SendNotification
        /// Description: Sends push notifications to the mobile terminals, whose MetaQuotes IDs are specified in the "Notifications" tab.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/sendnotification.html
        /// </summary>
        /// <param name="text">[in] The text of the notification. The message length should not exceed 255 characters.</param>
        public bool SendNotification (string text)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text);
            
            CommandManager.getInstance().ExecCommand(Command.SendNotification, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SendMail
        /// Description: Sends an email at the address specified in the settings window of the "Email" tab.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/sendmail.html
        /// </summary>
        /// <param name="subject">[in] Email header.</param>
        /// <param name="some_text">[in] Email body.</param>
        public bool SendMail (string subject, string some_text)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(subject);
            parameters.Add(some_text);
            
            CommandManager.getInstance().ExecCommand(Command.SendMail, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Sleep
        /// Description: The function suspends execution of the current Expert Advisor or script within a specified interval.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/sleep.html
        /// </summary>
        /// <param name="milliseconds">[in] Delay interval in milliseconds.</param>
        public void Sleep (int milliseconds)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(milliseconds);
            
            CommandManager.getInstance().ExecCommand(Command.Sleep, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TerminalClose
        /// Description: The function commands the terminal to complete operation.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/terminalclose.html
        /// </summary>
        /// <param name=""></param>
        public bool TerminalClose (int )
        {
            List<Object> parameters = new List<Object>();
            parameters.Add();
            
            CommandManager.getInstance().ExecCommand(Command.TerminalClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TesterStatistics
        /// Description: The function returns the value of the specified statistical parameter calculated based on testing results.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/testerstatistics.html
        /// </summary>
        /// <param name=""></param>
        public double TesterStatistics (ENUM_STATISTICS )
        {
            List<Object> parameters = new List<Object>();
            parameters.Add();
            
            CommandManager.getInstance().ExecCommand(Command.TesterStatistics, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WebRequest
        /// Description: The function sends an HTTP request to a specified server. The function has two versions:
        /// URL: http://mm.l/mql4/docs.mql4.com/common/webrequest.html
        /// </summary>
        /// <param name="method">[in] HTTP method.</param>
        /// <param name="url">[in] URL.</param>
        /// <param name="cookie">[in] Cookie value.</param>
        /// <param name="referer">[in] Value of the Referer header of the HTTP request.</param>
        /// <param name="timeout">[in] Timeout in milliseconds.</param>
        /// <param name="&data[]"></param>
        /// <param name="data_size">[in] Size of the data[] array.</param>
        /// <param name="&result[]"></param>
        /// <param name="&result_headers"></param>
        public int WebRequest (const string method, const string url, const string cookie, const string referer, int timeout, const char &data[], int data_size, char &result[], string &result_headers)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(method);
            parameters.Add(url);
            parameters.Add(cookie);
            parameters.Add(referer);
            parameters.Add(timeout);
            parameters.Add(&data[]);
            parameters.Add(data_size);
            parameters.Add(&result[]);
            parameters.Add(&result_headers);
            
            CommandManager.getInstance().ExecCommand(Command.WebRequest, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WebRequest
        /// Description: The function sends an HTTP request to a specified server. The function has two versions:
        /// URL: http://mm.l/mql4/docs.mql4.com/common/webrequest.html
        /// </summary>
        /// <param name="method">[in] HTTP method.</param>
        /// <param name="url">[in] URL.</param>
        /// <param name="headers">[in] Request headers of type "key: value", separated by a line break "\r\n".</param>
        /// <param name="timeout">[in] Timeout in milliseconds.</param>
        /// <param name="&data[]"></param>
        /// <param name="&result[]"></param>
        /// <param name="&result_headers"></param>
        public int WebRequest (const string method, const string url, const string headers, int timeout, const char &data[], char &result[], string &result_headers)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(method);
            parameters.Add(url);
            parameters.Add(headers);
            parameters.Add(timeout);
            parameters.Add(&data[]);
            parameters.Add(&result[]);
            parameters.Add(&result_headers);
            
            CommandManager.getInstance().ExecCommand(Command.WebRequest, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ZeroMemory
        /// Description: The function resets a variable passed to it by reference.
        /// URL: http://mm.l/mql4/docs.mql4.com/common/zeromemory.html
        /// </summary>
        /// <param name="variable">[in] [out] Variable passed by reference, you want to reset (initialize by zero values).</param>
        public void ZeroMemory (void variable)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(variable);
            
            CommandManager.getInstance().ExecCommand(Command.ZeroMemory, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayBsearch
        /// Description: The function searches for a specified value in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraybsearch.html
        /// </summary>
        /// <param name="array[]">[in] Numeric array for search.</param>
        /// <param name="value">[in] Value for search.</param>
        /// <param name="count">[in] Count of elements to search for. By default, it searches in the whole array.</param>
        /// <param name="start">[in] Starting index to search for. By default, the search starts at the first element.</param>
        /// <param name="direction">[in] Search direction. It can be any of the following values:</param>
        public int ArrayBsearch (const double& array[], double value, int count, int start, int direction)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            parameters.Add(count);
            parameters.Add(start);
            parameters.Add(direction);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayBsearch, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayBsearch
        /// Description: The function searches for a specified value in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraybsearch.html
        /// </summary>
        /// <param name="array[]">[in] Numeric array for search.</param>
        /// <param name="value">[in] Value for search.</param>
        /// <param name="count">[in] Count of elements to search for. By default, it searches in the whole array.</param>
        /// <param name="start">[in] Starting index to search for. By default, the search starts at the first element.</param>
        /// <param name="direction">[in] Search direction. It can be any of the following values:</param>
        public int ArrayBsearch (const float& array[], float value, int count, int start, int direction)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            parameters.Add(count);
            parameters.Add(start);
            parameters.Add(direction);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayBsearch, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayBsearch
        /// Description: The function searches for a specified value in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraybsearch.html
        /// </summary>
        /// <param name="array[]">[in] Numeric array for search.</param>
        /// <param name="value">[in] Value for search.</param>
        /// <param name="count">[in] Count of elements to search for. By default, it searches in the whole array.</param>
        /// <param name="start">[in] Starting index to search for. By default, the search starts at the first element.</param>
        /// <param name="direction">[in] Search direction. It can be any of the following values:</param>
        public int ArrayBsearch (const long& array[], long value, int count, int start, int direction)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            parameters.Add(count);
            parameters.Add(start);
            parameters.Add(direction);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayBsearch, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayBsearch
        /// Description: The function searches for a specified value in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraybsearch.html
        /// </summary>
        /// <param name="array[]">[in] Numeric array for search.</param>
        /// <param name="value">[in] Value for search.</param>
        /// <param name="count">[in] Count of elements to search for. By default, it searches in the whole array.</param>
        /// <param name="start">[in] Starting index to search for. By default, the search starts at the first element.</param>
        /// <param name="direction">[in] Search direction. It can be any of the following values:</param>
        public int ArrayBsearch (const int& array[], int value, int count, int start, int direction)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            parameters.Add(count);
            parameters.Add(start);
            parameters.Add(direction);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayBsearch, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayBsearch
        /// Description: The function searches for a specified value in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraybsearch.html
        /// </summary>
        /// <param name="array[]">[in] Numeric array for search.</param>
        /// <param name="value">[in] Value for search.</param>
        /// <param name="count">[in] Count of elements to search for. By default, it searches in the whole array.</param>
        /// <param name="start">[in] Starting index to search for. By default, the search starts at the first element.</param>
        /// <param name="direction">[in] Search direction. It can be any of the following values:</param>
        public int ArrayBsearch (const short& array[], short value, int count, int start, int direction)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            parameters.Add(count);
            parameters.Add(start);
            parameters.Add(direction);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayBsearch, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayBsearch
        /// Description: The function searches for a specified value in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraybsearch.html
        /// </summary>
        /// <param name="array[]">[in] Numeric array for search.</param>
        /// <param name="value">[in] Value for search.</param>
        /// <param name="count">[in] Count of elements to search for. By default, it searches in the whole array.</param>
        /// <param name="start">[in] Starting index to search for. By default, the search starts at the first element.</param>
        /// <param name="direction">[in] Search direction. It can be any of the following values:</param>
        public int ArrayBsearch (const char& array[], char value, int count, int start, int direction)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            parameters.Add(count);
            parameters.Add(start);
            parameters.Add(direction);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayBsearch, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayCopy
        /// Description: It copies an array into another one.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraycopy.html
        /// </summary>
        /// <param name="dst_array[]">[out] Destination array</param>
        /// <param name="src_array[]">[in] Source array</param>
        /// <param name="dst_start">[in] Starting index from the destination array. By default, start index is 0.</param>
        /// <param name="src_start">[in] Starting index for the source array. By default, start index is 0.</param>
        /// <param name="count">[in] Number of elements that should be copied. By default, the whole array is copied (count=).</param>
        public int ArrayCopy (void& dst_array[], const void& src_array[], int dst_start, int src_start, int count)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(dst_array[]);
            parameters.Add(src_array[]);
            parameters.Add(dst_start);
            parameters.Add(src_start);
            parameters.Add(count);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayCopy, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayCompare
        /// Description: The function returns the result of comparing two arrays of the same type. It can be used to compare arrays of
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraycompare.html
        /// </summary>
        /// <param name="array1[]">[in] First array.</param>
        /// <param name="array2[]">[in] Second array.</param>
        /// <param name="start1">[in] The element's initial index in the first array, from which comparison starts. The default start index - 0.</param>
        /// <param name="start2">[in] The element's initial index in the second array, from which comparison starts. The default start index - 0.</param>
        /// <param name="count">[in] Number of elements to be compared. All elements of both arrays participate in comparison by default (count=).</param>
        public int ArrayCompare (const void& array1[], const void& array2[], int start1, int start2, int count)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array1[]);
            parameters.Add(array2[]);
            parameters.Add(start1);
            parameters.Add(start2);
            parameters.Add(count);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayCompare, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayFree
        /// Description: It frees up a buffer of any dynamic array and sets the size of the zero dimension to 0.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayfree.html
        /// </summary>
        /// <param name="array[]">[in] Dynamic array.</param>
        public void ArrayFree (void& array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayFree, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayGetAsSeries
        /// Description: It checks direction of an array index.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraygetasseries.html
        /// </summary>
        /// <param name="array[]"></param>
        public bool ArrayGetAsSeries (const void& array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayGetAsSeries, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (char array[], char value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (short array[], short value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (int array[], int value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (long array[], long value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (float array[], float value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (double array[], double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (bool array[], bool value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayInitialize
        /// Description: The function initializes a numeric array by a preset value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayinitialize.html
        /// </summary>
        /// <param name="array[]">[out] Numeric array that should be initialized.</param>
        /// <param name="value">[in] New value that should be set to all array elements.</param>
        public int ArrayInitialize (uint array[], uint value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayInitialize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayFill
        /// Description: The function fills an array with the specified value.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayfill.html
        /// </summary>
        /// <param name="array[]">[out] Array of simple type (, , , , , , , , , , , , ).</param>
        /// <param name="start">[in] Starting index. In such a case, specified is ignored.</param>
        /// <param name="count">[in] Number of elements to fill.</param>
        /// <param name="value">[in] Value to fill the array with.</param>
        public void ArrayFill (void& array[], int start, int count, void value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(start);
            parameters.Add(count);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayFill, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayIsDynamic
        /// Description: The function checks whether an array is dynamic.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayisdynamic.html
        /// </summary>
        /// <param name="array[]">[in] Checked array.</param>
        public bool ArrayIsDynamic (const void& array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayIsDynamic, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayIsSeries
        /// Description: The function checks whether an array is a timeseries.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayisseries.html
        /// </summary>
        /// <param name="array[]">[in] Checked array.</param>
        public bool ArrayIsSeries (const void& array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayIsSeries, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayMaximum
        /// Description: The function searches a maximal element in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraymaximum.html
        /// </summary>
        /// <param name="array[]">[in] A numeric array, in which search is made.</param>
        /// <param name="count">[in] Number of elements for search. By default, searches in the entire array (count=).</param>
        /// <param name="start">[in] Index to start checking with.</param>
        public int ArrayMaximum (const void& array[], int count, int start)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(count);
            parameters.Add(start);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayMaximum, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayMinimum
        /// Description: The function searches a minimal element in a one-dimension numeric array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayminimum.html
        /// </summary>
        /// <param name="array[]">[in] A numeric array, in which search is made.</param>
        /// <param name="count">[in] Number of elements for search. By default, searches in the entire array (count=).</param>
        /// <param name="start">[in] Index to start checking with.</param>
        public int ArrayMinimum (const void& array[], int count, int start)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(count);
            parameters.Add(start);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayMinimum, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayRange
        /// Description: The function returns the number of elements in a selected array dimension.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayrange.html
        /// </summary>
        /// <param name="array[]">[in] Checked array.</param>
        /// <param name="rank_index">[in] Index of dimension.</param>
        public int ArrayRange (const void& array[], int rank_index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(rank_index);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayRange, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayResize
        /// Description: The function sets a new size for the first dimension
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arrayresize.html
        /// </summary>
        /// <param name="array[]">[out] Array for changing sizes.</param>
        /// <param name="new_size">[in] New size for the first dimension.</param>
        /// <param name="reserve_size">[in] Optional parameter. Distributed size to get reserve.</param>
        public int ArrayResize (void& array[], int new_size, int reserve_size)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(new_size);
            parameters.Add(reserve_size);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayResize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArraySetAsSeries
        /// Description: The function sets the AS_SERIES flag to a selected
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraysetasseries.html
        /// </summary>
        /// <param name="array[]">[in][out] Numeric array to set.</param>
        /// <param name="flag">[in] Array indexing direction.</param>
        public bool ArraySetAsSeries (const void& array[], bool flag)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(flag);
            
            CommandManager.getInstance().ExecCommand(Command.ArraySetAsSeries, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArraySize
        /// Description: The function returns the number of elements of a selected array.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraysize.html
        /// </summary>
        /// <param name="array[]">[in] Array of any type.</param>
        public int ArraySize (const void& array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            
            CommandManager.getInstance().ExecCommand(Command.ArraySize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArraySort
        /// Description: Sorts numeric arrays by first dimension.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraysort.html
        /// </summary>
        /// <param name="array[]">[in][out] Numeric array for sorting.</param>
        /// <param name="count">[in] Count of elements to sort. By default, it sorts the whole array.</param>
        /// <param name="start">[in] Starting index to sort. By default, the sort starts at the first element.</param>
        /// <param name="direction">[in] Sort direction. It can be any of the following values:</param>
        public bool ArraySort (void& array[], int count, int start, int direction)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(count);
            parameters.Add(start);
            parameters.Add(direction);
            
            CommandManager.getInstance().ExecCommand(Command.ArraySort, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayCopyRates
        /// Description: Copies rates data to the array and returns the amount of bars copied. There are 2 variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraycopyrates.html
        /// </summary>
        /// <param name="rates_array[]">[out] Destination array of type.</param>
        /// <param name="symbol">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        public int ArrayCopyRates (MqlRates& rates_array[], string symbol, int timeframe)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(rates_array[]);
            parameters.Add(symbol);
            parameters.Add(timeframe);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayCopyRates, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayCopyRates
        /// Description: Copies rates data to the array and returns the amount of bars copied. There are 2 variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraycopyrates.html
        /// </summary>
        /// <param name="dest_array[][]"></param>
        /// <param name="symbol">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        public int ArrayCopyRates (void& dest_array[][], string symbol, int timeframe)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(dest_array[][]);
            parameters.Add(symbol);
            parameters.Add(timeframe);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayCopyRates, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayCopySeries
        /// Description: Copies a series array to another one and returns the count of the copied elements.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraycopyseries.html
        /// </summary>
        /// <param name="array[]">[out] Destination array of double type.</param>
        /// <param name="series_index">[in] Series array identifier. It can be any of the enumeration values.</param>
        /// <param name="symbol">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        public int ArrayCopySeries (void& array[], int series_index, string symbol, int timeframe)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(series_index);
            parameters.Add(symbol);
            parameters.Add(timeframe);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayCopySeries, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ArrayDimension
        /// Description: Returns the multidimensional array rank.
        /// URL: http://mm.l/mql4/docs.mql4.com/array/arraydimension.html
        /// </summary>
        /// <param name="array[]">[in] Array for which the rank will be returned.</param>
        public int ArrayDimension (void& array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            
            CommandManager.getInstance().ExecCommand(Command.ArrayDimension, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CharToString
        /// Description: Converting a symbol code into a one-character string
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/chartostring.html
        /// </summary>
        /// <param name="char_code">[in] Code of ANSI symbol.</param>
        public string CharToString (uchar char_code)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(char_code);
            
            CommandManager.getInstance().ExecCommand(Command.CharToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CharArrayToString
        /// Description: It copies and converts part of array of uchar type into a returned string.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/chararraytostring.html
        /// </summary>
        /// <param name="array[]">[in] Array of uchar type.</param>
        /// <param name="start">[in] Position from which copying starts. by default 0 is used.</param>
        /// <param name="count">[in] Number of array elements for copying. Defines the length of a resulting string. Default value is -1, which means copying up to the array end, or till terminal 0.</param>
        /// <param name="codepage">[in] The value of the code page. There is a number of built-in constants for the most used .</param>
        public string CharArrayToString (uchar array[], int start, int count, uint codepage)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(start);
            parameters.Add(count);
            parameters.Add(codepage);
            
            CommandManager.getInstance().ExecCommand(Command.CharArrayToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ColorToARGB
        /// Description: The function converts
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/colortoargb.html
        /// </summary>
        /// <param name="clr">[in] Color value in color type variable.</param>
        /// <param name="alpha">[in] The value of the alpha channel used to receive the color in format. The value may be set from 0 (a color of a foreground pixel does not change the display of an underlying one) up to 255 (a color of an underlying pixel is completely replaced by the foreground pixel's one). Color transparency in percentage terms is calculated as (1-alpha/255)*100%. In other words, the lesser value of the alpha channel leads to more transparent color.</param>
        public uint ColorToARGB (color clr, uchar alpha)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(clr);
            parameters.Add(alpha);
            
            CommandManager.getInstance().ExecCommand(Command.ColorToARGB, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ColorToString
        /// Description: It converts color value into string of "R,G,B" form.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/colortostring.html
        /// </summary>
        /// <param name="color_value">[in] Color value in color type variable.</param>
        /// <param name="color_name">[in] Return color name if it is identical to one of predefined .</param>
        public string ColorToString (color color_value, bool color_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(color_value);
            parameters.Add(color_name);
            
            CommandManager.getInstance().ExecCommand(Command.ColorToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: DoubleToString
        /// Description: Converting numeric value into text string.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/doubletostring.html
        /// </summary>
        /// <param name="value">[in] Value with a floating point.</param>
        /// <param name="digits">[in] Accuracy format. If the digits value is in the range between 0 and 16, a string presentation of a number with the specified number of digits after the point will be obtained. If the digits value is in the range between -1 and -16, a string representation of a number in the scientific format with the specified number of digits after the decimal point will be obtained. In all other cases the string value will contain 8 digits after the decimal point.</param>
        public string DoubleToString (double value, int digits)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            parameters.Add(digits);
            
            CommandManager.getInstance().ExecCommand(Command.DoubleToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: EnumToString
        /// Description: Converting an enumeration value of any type to a text form.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/enumtostring.html
        /// </summary>
        /// <param name="value">[in] Any type enumeration value.</param>
        public string EnumToString (any_enum value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.EnumToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IntegerToString
        /// Description: This function converts value of integer type into a string of a specified length and returns the obtained string.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/integertostring.html
        /// </summary>
        /// <param name="number">[in] Number for conversion.</param>
        /// <param name="str_len">[in] String length. If the resulting string length is larger than the specified one, the string is not cut off. If it is smaller, filler symbols will be added to the left.</param>
        /// <param name="fill_symbol">[in] Filler symbol. By default it is a space.</param>
        public string IntegerToString (long number, int str_len, ushort fill_symbol)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(number);
            parameters.Add(str_len);
            parameters.Add(fill_symbol);
            
            CommandManager.getInstance().ExecCommand(Command.IntegerToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ShortToString
        /// Description: It converts the symbol code (unicode) into one-symbol string and returns resulting string.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/shorttostring.html
        /// </summary>
        /// <param name="symbol_code">[in] Symbol code. Instead of a symbol code you can use literal string containing a symbol or a literal string with 2-byte hexadecimal code corresponding to the symbol from the Unicode table.</param>
        public string ShortToString (ushort symbol_code)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_code);
            
            CommandManager.getInstance().ExecCommand(Command.ShortToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ShortArrayToString
        /// Description: It copies part of array into a returned string.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/shortarraytostring.html
        /// </summary>
        /// <param name="array[]">[in] Array of ushort type (analog of wchar_t type).</param>
        /// <param name="start">[in] Position, from which copying starts, Default - 0.</param>
        /// <param name="count">[in] Number of array elements to copy. Defines the length of a resulting string. Default value is -1, which means copying up to the array end, or till terminal 0.</param>
        public string ShortArrayToString (ushort array[], int start, int count)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(start);
            parameters.Add(count);
            
            CommandManager.getInstance().ExecCommand(Command.ShortArrayToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeToString
        /// Description: Converting a value containing time in seconds elapsed since 01.01.1970 into a string of "yyyy.mm.dd hh:mi" format.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/timetostring.html
        /// </summary>
        /// <param name="value">[in] Time in seconds from 00:00 1970/01/01.</param>
        /// <param name="mode">[in] Additional data input mode. Can be one or combined flag: TIME_DATE gets result as "yyyy.mm.dd", TIME_MINUTES gets result as "hh:mm", TIME_SECONDS gets results as "hh:mm:ss".</param>
        public string TimeToString (datetime value, int mode)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            parameters.Add(mode);
            
            CommandManager.getInstance().ExecCommand(Command.TimeToString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: NormalizeDouble
        /// Description: Rounding floating point number to a specified accuracy.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/normalizedouble.html
        /// </summary>
        /// <param name="value">[in] Value with a floating point.</param>
        /// <param name="digits">[in] Accuracy format, number of digits after point (0-8).</param>
        public double NormalizeDouble (double value, int digits)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            parameters.Add(digits);
            
            CommandManager.getInstance().ExecCommand(Command.NormalizeDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToCharArray
        /// Description: Symbol-wise copies
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/stringtochararray.html
        /// </summary>
        /// <param name="text_string">[in] String to copy.</param>
        /// <param name="array[]">[out] Array of uchar type.</param>
        /// <param name="start">[in] Position from which copying starts. Default - 0.</param>
        /// <param name="count">[in] Number of array elements to copy. Defines length of a resulting string. Default value is -1, which means copying up to the array end, or till terminating '\0'. Terminating zero will also be copied to the recipient array, in this case the size of a dynamic array can be increased if necessary to the size of the string. If the size of the dynamic array exceeds the length of the string, the size of the array will not be reduced.</param>
        /// <param name="codepage">[in] The value of the code page. For the most-used provide appropriate constants.</param>
        public int StringToCharArray (string text_string, uchar& array[], int start, int count, uint codepage)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text_string);
            parameters.Add(array[]);
            parameters.Add(start);
            parameters.Add(count);
            parameters.Add(codepage);
            
            CommandManager.getInstance().ExecCommand(Command.StringToCharArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToColor
        /// Description: Converting "R,G,B" string or string with color name into color type value.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/stringtocolor.html
        /// </summary>
        /// <param name="color_string">[in] String representation of a color of "R,G,B" type or name of one of predefined .</param>
        public color StringToColor (string color_string)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(color_string);
            
            CommandManager.getInstance().ExecCommand(Command.StringToColor, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (color) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToDouble
        /// Description: The function converts string containing a symbol representation of number into number of double type.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/stringtodouble.html
        /// </summary>
        /// <param name="value">[in] String containing a symbol representation of a number.</param>
        public double StringToDouble (string value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.StringToDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToInteger
        /// Description: The function converts string containing a symbol representation of number into number of int (integer) type.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/stringtointeger.html
        /// </summary>
        /// <param name="value">[in] String containing a number.</param>
        public long StringToInteger (string value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.StringToInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToShortArray
        /// Description: The function symbol-wise copies a string into a specified place of an array of ushort type.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/stringtoshortarray.html
        /// </summary>
        /// <param name="text_string">[in] String to copy</param>
        /// <param name="array[]">[out] Array of type (analog of wchar_t type).</param>
        /// <param name="start">[in] Position, from which copying starts. Default - 0.</param>
        /// <param name="count">[in] Number of array elements to copy. Defines length of a resulting string. Default value is -1, which means copying up to the array end, or till terminal 0.Terminal 0 will also be copied to the recipient array, in this case the size of a dynamic array can be increased if necessary to the size of the string. If the size of the dynamic array exceeds the length of the string, the size of the array will not be reduced.</param>
        public int StringToShortArray (string text_string, ushort& array[], int start, int count)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text_string);
            parameters.Add(array[]);
            parameters.Add(start);
            parameters.Add(count);
            
            CommandManager.getInstance().ExecCommand(Command.StringToShortArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToTime
        /// Description: The function converts a string containing time or date in "yyyy.mm.dd [hh:mi]" format into datetime type.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/stringtotime.html
        /// </summary>
        /// <param name="value">[in] String in " yyyy.mm.dd hh:mi " format.</param>
        public datetime StringToTime (string value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.StringToTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringFormat
        /// Description: The function formats obtained parameters and returns a string.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/stringformat.html
        /// </summary>
        /// <param name="format">[in] String containing method of formatting. Formatting rules are the same as for the function.</param>
        public string StringFormat (string format)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(format);
            
            CommandManager.getInstance().ExecCommand(Command.StringFormat, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CharToStr
        /// Description: Conversion of the symbol code into a one-character string.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/chartostr.html
        /// </summary>
        /// <param name="char_code">[in] ASCII char code.</param>
        public string CharToStr (uchar char_code)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(char_code);
            
            CommandManager.getInstance().ExecCommand(Command.CharToStr, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: DoubleToStr
        /// Description: Returns text string with the specified numerical value converted into a specified precision format.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/doubletostr.html
        /// </summary>
        /// <param name="value">[in] Floating point value.</param>
        /// <param name="digits">[in] Precision format, number of digits after decimal point (0-8).</param>
        public string DoubleToStr (double value, int digits)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            parameters.Add(digits);
            
            CommandManager.getInstance().ExecCommand(Command.DoubleToStr, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StrToDouble
        /// Description: Converts string representation of number to double type (double-precision format with floating point).
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/strtodouble.html
        /// </summary>
        /// <param name="value">[in] String containing the number character representation format.</param>
        public double StrToDouble (string value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.StrToDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StrToInteger
        /// Description: Converts string containing the value character representation into a value of the int (integer) type.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/strtointeger.html
        /// </summary>
        /// <param name="value">[in] String containing the integer character representation format.</param>
        public int StrToInteger (string value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.StrToInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StrToTime
        /// Description: Converts string in the format "yyyy.mm.dd hh:mi" to datetime type (the amount of seconds that have passed since 1 Jan., 1970).
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/strtotime.html
        /// </summary>
        /// <param name="value">[in] String having "yyyy.mm.dd hh:mi " format.</param>
        public datetime StrToTime (string value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.StrToTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeToStr
        /// Description: Converts value containing time in seconds that has passed since January 1, 1970, into a string of "yyyy.mm.dd hh:mi" format.
        /// URL: http://mm.l/mql4/docs.mql4.com/convert/timetostr.html
        /// </summary>
        /// <param name="value">[in] Positive amount of seconds that have passed since 00:00, January 1, 1970.</param>
        /// <param name="mode">[in] Optional data output mode can be one or combination of:TIME_DATE gets result as "yyyy.mm.dd",TIME_MINUTES gets result as "hh:mi",TIME_SECONDS gets result as "hh:mi:ss".</param>
        public string TimeToStr (datetime value, int mode)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            parameters.Add(mode);
            
            CommandManager.getInstance().ExecCommand(Command.TimeToStr, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathAbs
        /// Description: The function returns the absolute value (modulus) of the specified numeric value.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathabs.html
        /// </summary>
        /// <param name="value">[in] Numeric value.</param>
        public double MathAbs (double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.MathAbs, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathArccos
        /// Description: The function returns the arccosine of x within the range 0 to
        /// URL: http://mm.l/mql4/docs.mql4.com/math/matharccos.html
        /// </summary>
        /// <param name="val">[in] The val value between -1 and 1, the arc cosine of which is to be calculated.</param>
        public double MathArccos (double val)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(val);
            
            CommandManager.getInstance().ExecCommand(Command.MathArccos, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathArcsin
        /// Description: The function returns the arc sine of x within the range of -
        /// URL: http://mm.l/mql4/docs.mql4.com/math/matharcsin.html
        /// </summary>
        /// <param name="val">[in] The val value between -1 and 1, the arc sine of which is to be calculated.</param>
        public double MathArcsin (double val)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(val);
            
            CommandManager.getInstance().ExecCommand(Command.MathArcsin, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathArctan
        /// Description: The function returns the arc tangent of x. If x is equal to 0, the function returns 0.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/matharctan.html
        /// </summary>
        /// <param name="value">[in] A number representing a tangent.</param>
        public double MathArctan (double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.MathArctan, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathCeil
        /// Description: The function returns integer numeric value closest from above.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathceil.html
        /// </summary>
        /// <param name="val">[in] Numeric value.</param>
        public double MathCeil (double val)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(val);
            
            CommandManager.getInstance().ExecCommand(Command.MathCeil, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathCos
        /// Description: The function returns the cosine of an angle.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathcos.html
        /// </summary>
        /// <param name="value">[in] Angle in radians.</param>
        public double MathCos (double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.MathCos, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathExp
        /// Description: The function returns the value of e raised to the power of d.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathexp.html
        /// </summary>
        /// <param name="value">[in] A number specifying the power.</param>
        public double MathExp (double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.MathExp, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathFloor
        /// Description: The function returns integer numeric value closest from below.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathfloor.html
        /// </summary>
        /// <param name="val">[in] Numeric value.</param>
        public double MathFloor (double val)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(val);
            
            CommandManager.getInstance().ExecCommand(Command.MathFloor, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathLog
        /// Description: The function returns a natural logarithm.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathlog.html
        /// </summary>
        /// <param name="val">[in] Value logarithm of which is to be found.</param>
        public double MathLog (double val)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(val);
            
            CommandManager.getInstance().ExecCommand(Command.MathLog, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathLog10
        /// Description: Returns the logarithm of a number by base 10.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathlog10.html
        /// </summary>
        /// <param name="val">[in] Numeric value the common logarithm of which is to be calculated.</param>
        public double MathLog10 (double val)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(val);
            
            CommandManager.getInstance().ExecCommand(Command.MathLog10, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathMax
        /// Description: The function returns the maximal value of two values.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathmax.html
        /// </summary>
        /// <param name="value1">[in] First numeric value.</param>
        /// <param name="value2">[in] Second numeric value.</param>
        public double MathMax (double value1, double value2)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value1);
            parameters.Add(value2);
            
            CommandManager.getInstance().ExecCommand(Command.MathMax, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathMin
        /// Description: The function returns the minimal value of two values.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathmin.html
        /// </summary>
        /// <param name="value1">[in] First numeric value.</param>
        /// <param name="value2">[in] Second numeric value.</param>
        public double MathMin (double value1, double value2)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value1);
            parameters.Add(value2);
            
            CommandManager.getInstance().ExecCommand(Command.MathMin, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathMod
        /// Description: The function returns the real remainder of division of two numbers.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathmod.html
        /// </summary>
        /// <param name="value">[in] Dividend value.</param>
        /// <param name="value2">[in] Divisor value.</param>
        public double MathMod (double value, double value2)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            parameters.Add(value2);
            
            CommandManager.getInstance().ExecCommand(Command.MathMod, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathPow
        /// Description: The function raises a base to a specified power.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathpow.html
        /// </summary>
        /// <param name="base">[in] Base.</param>
        /// <param name="exponent">[in] Exponent value.</param>
        public double MathPow (double base, double exponent)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(base);
            parameters.Add(exponent);
            
            CommandManager.getInstance().ExecCommand(Command.MathPow, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathRand
        /// Description: Returns a pseudorandom integer within the range of 0 to 32767.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathrand.html
        /// </summary>
        public int MathRand (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.MathRand, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathRound
        /// Description: The function returns a value rounded off to the nearest integer of the specified numeric value.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathround.html
        /// </summary>
        /// <param name="value">[in] Numeric value before rounding.</param>
        public double MathRound (double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.MathRound, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathSin
        /// Description: Returns the sine of a specified angle.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathsin.html
        /// </summary>
        /// <param name="value">[in] Angle in radians.</param>
        public double MathSin (double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.MathSin, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathSqrt
        /// Description: Returns the square root of a number.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathsqrt.html
        /// </summary>
        /// <param name="value">[in] Positive numeric value.</param>
        public double MathSqrt (double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.MathSqrt, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathSrand
        /// Description: Sets the starting point for generating a series of pseudorandom integers.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathsrand.html
        /// </summary>
        /// <param name="seed">[in] Starting number for the sequence of random numbers.</param>
        public void MathSrand (int seed)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(seed);
            
            CommandManager.getInstance().ExecCommand(Command.MathSrand, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathTan
        /// Description: The function returns a tangent of a number.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathtan.html
        /// </summary>
        /// <param name="rad">[in] Angle in radians.</param>
        public double MathTan (double rad)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(rad);
            
            CommandManager.getInstance().ExecCommand(Command.MathTan, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MathIsValidNumber
        /// Description: It checks the correctness of a real number.
        /// URL: http://mm.l/mql4/docs.mql4.com/math/mathisvalidnumber.html
        /// </summary>
        /// <param name="number">[in] Checked numeric value.</param>
        public bool MathIsValidNumber (double number)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(number);
            
            CommandManager.getInstance().ExecCommand(Command.MathIsValidNumber, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringAdd
        /// Description: The function adds
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringadd.html
        /// </summary>
        /// <param name="string_var">[in][out] String, to which another one is added.</param>
        /// <param name="add_substring">[in] String that is added to the end of a source string.</param>
        public bool StringAdd (string& string_var, string add_substring)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            parameters.Add(add_substring);
            
            CommandManager.getInstance().ExecCommand(Command.StringAdd, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringBufferLen
        /// Description: The function returns the size of buffer allocated for the string.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringbufferlen.html
        /// </summary>
        /// <param name="string_var">[in] String.</param>
        public int StringBufferLen (string string_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            
            CommandManager.getInstance().ExecCommand(Command.StringBufferLen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringCompare
        /// Description: The function compares two strings and returns the comparison result in form of an integer.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringcompare.html
        /// </summary>
        /// <param name="string1">[in] The first string.</param>
        /// <param name="string2">[in] The second string.</param>
        /// <param name="case_sensitive">[in] Case sensitivity mode selection. If it is true, then "A">"a". If it is false, then "A"="a". By default the value is equal to true.</param>
        public int StringCompare (const string& string1, const string& string2, bool case_sensitive)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string1);
            parameters.Add(string2);
            parameters.Add(case_sensitive);
            
            CommandManager.getInstance().ExecCommand(Command.StringCompare, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringConcatenate
        /// Description: The function returns the string
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringconcatenate.html
        /// </summary>
        /// <param name="argument1"></param>
        /// <param name="argument2"></param>
        public string StringConcatenate (void argument1, void argument2)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(argument1);
            parameters.Add(argument2);
            
            CommandManager.getInstance().ExecCommand(Command.StringConcatenate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringFill
        /// Description: It fills out a selected string by specified symbols.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringfill.html
        /// </summary>
        /// <param name="string_var">[in][out] String, that will be filled out by the selected symbol.</param>
        /// <param name="character">[in] Symbol, by which the string will be filled out.</param>
        public bool StringFill (string& string_var, ushort character)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            parameters.Add(character);
            
            CommandManager.getInstance().ExecCommand(Command.StringFill, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringFind
        /// Description: Search for a substring in a string.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringfind.html
        /// </summary>
        /// <param name="string_value">[in] String, in which search is made.</param>
        /// <param name="match_substring">[in] Searched substring.</param>
        /// <param name="start_pos">[in] Position in the string from which search is started.</param>
        public int StringFind (string string_value, string match_substring, int start_pos)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_value);
            parameters.Add(match_substring);
            parameters.Add(start_pos);
            
            CommandManager.getInstance().ExecCommand(Command.StringFind, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringGetCharacter
        /// Description: Returns value of a symbol, located in the specified position of a string.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringgetcharacter.html
        /// </summary>
        /// <param name="string_value">[in] String.</param>
        /// <param name="pos">[in] Position of a symbol in the string. Can be from 0 to (text) -1.</param>
        public ushort StringGetCharacter (string string_value, int pos)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_value);
            parameters.Add(pos);
            
            CommandManager.getInstance().ExecCommand(Command.StringGetCharacter, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (ushort) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringInit
        /// Description: Initializes a string by specified symbols and provides the specified string size.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringinit.html
        /// </summary>
        /// <param name="string_var">[in][out] String that should be initialized and deinitialized.</param>
        /// <param name="new_len">[in] String length after initialization. If length=0, it deinitializes the string, i.e. the string buffer is cleared and the buffer address is zeroed.</param>
        /// <param name="character">[in] Symbol to fill the string.</param>
        public bool StringInit (string& string_var, int new_len, ushort character)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            parameters.Add(new_len);
            parameters.Add(character);
            
            CommandManager.getInstance().ExecCommand(Command.StringInit, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringLen
        /// Description: Returns the number of symbols in a string.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringlen.html
        /// </summary>
        /// <param name="string_value">[in] String to calculate length.</param>
        public int StringLen (string string_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_value);
            
            CommandManager.getInstance().ExecCommand(Command.StringLen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringReplace
        /// Description: It replaces all the found substrings of a string by a set sequence of symbols.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringreplace.html
        /// </summary>
        /// <param name="str">[in][out] The string in which you are going to replace substrings.</param>
        /// <param name="find">[in] The desired substring to replace.</param>
        /// <param name="replacement">[in] The string that will be inserted instead of the found one.</param>
        public int StringReplace (string& str, const string find, const string replacement)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(str);
            parameters.Add(find);
            parameters.Add(replacement);
            
            CommandManager.getInstance().ExecCommand(Command.StringReplace, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringSetCharacter
        /// Description: Returns copy of a string with a changed character in a specified position.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringsetcharacter.html
        /// </summary>
        /// <param name="string_var">[in][out] String.</param>
        /// <param name="pos">[in] Position of a character in a string. Can be from 0 to (text).</param>
        /// <param name="character">[in] Symbol code Unicode.</param>
        public bool StringSetCharacter (string& string_var, int pos, ushort character)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            parameters.Add(pos);
            parameters.Add(character);
            
            CommandManager.getInstance().ExecCommand(Command.StringSetCharacter, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringSplit
        /// Description: Gets substrings by a specified separator from the specified string, returns the number of substrings obtained.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringsplit.html
        /// </summary>
        /// <param name="string_value">[in] The string from which you need to get substrings. The string will not change.</param>
        /// <param name="separator"></param>
        /// <param name="&"></param>
        public int StringSplit (const string string_value, const ushort separator, string &)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_value);
            parameters.Add(separator);
            parameters.Add(&);
            
            CommandManager.getInstance().ExecCommand(Command.StringSplit, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringSubstr
        /// Description: Extracts a substring from a text string starting from the specified position.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringsubstr.html
        /// </summary>
        /// <param name="string_value">[in] String to extract a substring from.</param>
        /// <param name="start_pos">[in] Initial position of a substring. Can be from 0 to (text) -1.</param>
        /// <param name="length">[in] Length of an extracted substring. If the parameter value is equal or less than 0 or parameter isn't set, the substring will be extracted from the indicated position till the string end.</param>
        public string StringSubstr (string string_value, int start_pos, int length)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_value);
            parameters.Add(start_pos);
            parameters.Add(length);
            
            CommandManager.getInstance().ExecCommand(Command.StringSubstr, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToLower
        /// Description: Transforms all symbols of a selected string into lowercase.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringtolower.html
        /// </summary>
        /// <param name="string_var">[in][out] String.</param>
        public bool StringToLower (string& string_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            
            CommandManager.getInstance().ExecCommand(Command.StringToLower, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringToUpper
        /// Description: Transforms all symbols of a selected string into capitals.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringtoupper.html
        /// </summary>
        /// <param name="string_var">[in][out] String.</param>
        public bool StringToUpper (string& string_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            
            CommandManager.getInstance().ExecCommand(Command.StringToUpper, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringTrimLeft
        /// Description: The function cuts line feed characters, spaces and tabs in the left part of the string till the first meaningful symbol. The string is modified at place.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringtrimleft.html
        /// </summary>
        /// <param name="text">[in] String that will be cut from the left.</param>
        public string StringTrimLeft (const string text)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text);
            
            CommandManager.getInstance().ExecCommand(Command.StringTrimLeft, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringTrimRight
        /// Description: The function cuts line feed characters, spaces and tabs in the right part of the string after the last meaningful symbol. The string is modified at place.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringtrimright.html
        /// </summary>
        /// <param name="text">[in] String that will be cut from the right.</param>
        public string StringTrimRight (const string text)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text);
            
            CommandManager.getInstance().ExecCommand(Command.StringTrimRight, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringGetChar
        /// Description: Returns character (code) from the specified position in the string.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringgetchar.html
        /// </summary>
        /// <param name="string_value">[in] String.</param>
        /// <param name="pos">[in] Char position in the string. Can be from 0 to (text) -1.</param>
        public ushort StringGetChar (string string_value, int pos)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_value);
            parameters.Add(pos);
            
            CommandManager.getInstance().ExecCommand(Command.StringGetChar, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (ushort) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StringSetChar
        /// Description: Returns the string copy with changed character in the specified position.
        /// URL: http://mm.l/mql4/docs.mql4.com/strings/stringsetchar.html
        /// </summary>
        /// <param name="string_var">[in] Source string.</param>
        /// <param name="pos">[in] The character position in the string. Can be from 0 to (text).</param>
        /// <param name="value">[in] New char ASCII-code.</param>
        public string StringSetChar (string string_var, int pos, ushort value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(string_var);
            parameters.Add(pos);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.StringSetChar, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeCurrent
        /// Description: Returns the last known server time, time of the last quote receipt for one of the symbols selected in the "Market Watch" window. In the
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timecurrent.html
        /// </summary>
        public datetime TimeCurrent (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TimeCurrent, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeCurrent
        /// Description: Returns the last known server time, time of the last quote receipt for one of the symbols selected in the "Market Watch" window. In the
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timecurrent.html
        /// </summary>
        /// <param name="dt_struct">[out] structure type variable.</param>
        public datetime TimeCurrent (MqlDateTime& dt_struct)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(dt_struct);
            
            CommandManager.getInstance().ExecCommand(Command.TimeCurrent, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeLocal
        /// Description: Returns the local time of a computer, where the client terminal is running. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timelocal.html
        /// </summary>
        public datetime TimeLocal (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TimeLocal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeLocal
        /// Description: Returns the local time of a computer, where the client terminal is running. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timelocal.html
        /// </summary>
        /// <param name="dt_struct">[out] Variable of structure type .</param>
        public datetime TimeLocal (MqlDateTime& dt_struct)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(dt_struct);
            
            CommandManager.getInstance().ExecCommand(Command.TimeLocal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeGMT
        /// Description: Returns the GMT, which is calculated taking into account the DST switch by the local time on the computer where the client terminal is running. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timegmt.html
        /// </summary>
        public datetime TimeGMT (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TimeGMT, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeGMT
        /// Description: Returns the GMT, which is calculated taking into account the DST switch by the local time on the computer where the client terminal is running. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timegmt.html
        /// </summary>
        /// <param name="dt_struct">[out] Variable of structure type .</param>
        public datetime TimeGMT (MqlDateTime& dt_struct)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(dt_struct);
            
            CommandManager.getInstance().ExecCommand(Command.TimeGMT, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeDaylightSavings
        /// Description: Returns correction for daylight saving time in seconds, if the switch to summer time has been made. It depends on the time settings of your computer.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timedaylightsavings.html
        /// </summary>
        public int TimeDaylightSavings (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TimeDaylightSavings, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeGMTOffset
        /// Description: Returns the current difference between GMT time and the local computer time in seconds, taking into account switch to winter or summer time. Depends on the time settings of your computer.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timegmtoffset.html
        /// </summary>
        public int TimeGMTOffset (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TimeGMTOffset, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeToStruct
        /// Description: Converts a value of datetime type (number of seconds since 01.01.1970) into a structure variable
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timetostruct.html
        /// </summary>
        /// <param name="dt">[in] Date value to convert.</param>
        /// <param name="dt_struct">[out] Variable of structure type MqlDateTime.</param>
        public void TimeToStruct (datetime dt, MqlDateTime& dt_struct)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(dt);
            parameters.Add(dt_struct);
            
            CommandManager.getInstance().ExecCommand(Command.TimeToStruct, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: StructToTime
        /// Description: Converts a structure variable
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/structtotime.html
        /// </summary>
        /// <param name="dt_struct">[in] Variable of structure type MqlDateTime.</param>
        public datetime StructToTime (MqlDateTime$ dt_struct)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(dt_struct);
            
            CommandManager.getInstance().ExecCommand(Command.StructToTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Day
        /// Description: Returns the current day of the month, i.e., the day of month of the last known server time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/day.html
        /// </summary>
        public int Day (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Day, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: DayOfWeek
        /// Description: Returns the current zero-based day of the week (0-Sunday,1,2,3,4,5,6) of the last known server time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/dayofweek.html
        /// </summary>
        public int DayOfWeek (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.DayOfWeek, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: DayOfYear
        /// Description: Returns the current day of the year (1 means 1 January,..,365(6) does 31 December), i.e., the day of year of the last known server time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/dayofyear.html
        /// </summary>
        public int DayOfYear (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.DayOfYear, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Hour
        /// Description: Returns the hour (0,1,2,..23) of the last known server time by the moment of the program start.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/hour.html
        /// </summary>
        public int Hour (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Hour, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Minute
        /// Description: Returns the current minute (0,1,2,..59) of the last known server time by the moment of the program start.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/minute.html
        /// </summary>
        public int Minute (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Minute, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Month
        /// Description: Returns the current month as number (1-January,2,3,4,5,6,7,8,9,10,11,12), i.e., the number of month of the last known server time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/month.html
        /// </summary>
        public int Month (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Month, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Seconds
        /// Description: Returns the amount of seconds elapsed from the beginning of the current minute of the last known server time by the moment of the program start.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/seconds.html
        /// </summary>
        public int Seconds (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Seconds, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeDay
        /// Description: Returns the day of month (1 - 31) of the specified date.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timeday.html
        /// </summary>
        /// <param name="date">[in] Datetime as number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeDay (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeDay, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeDayOfWeek
        /// Description: Returns the zero-based day of week (0 means Sunday,1,2,3,4,5,6) of the specified date.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timedayofweek.html
        /// </summary>
        /// <param name="date">[in] Datetime as number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeDayOfWeek (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeDayOfWeek, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeDayOfYear
        /// Description: Returns the day of year of the specified date.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timedayofyear.html
        /// </summary>
        /// <param name="date">[in] Datetime as number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeDayOfYear (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeDayOfYear, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeHour
        /// Description: Returns the hour of the specified time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timehour.html
        /// </summary>
        /// <param name="date">[in] Datetime is the number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeHour (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeHour, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeMinute
        /// Description: Returns the minute of the specified time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timeminute.html
        /// </summary>
        /// <param name="date">[in] Datetime as number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeMinute (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeMinute, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeMonth
        /// Description: Returns the month number of the specified time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timemonth.html
        /// </summary>
        /// <param name="date">[in] Datetime as number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeMonth (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeMonth, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeSeconds
        /// Description: Returns the amount of seconds elapsed from the beginning of the minute of the specified time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timeseconds.html
        /// </summary>
        /// <param name="date">[in] Datetime as number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeSeconds (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeSeconds, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TimeYear
        /// Description: Returns year of the specified date.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/timeyear.html
        /// </summary>
        /// <param name="date">[in] Datetime as number of seconds elapsed since midnight (00:00:00), January 1, 1970.</param>
        public int TimeYear (datetime date)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(date);
            
            CommandManager.getInstance().ExecCommand(Command.TimeYear, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Year
        /// Description: Returns the current year, i.e., the year of the last known server time.
        /// URL: http://mm.l/mql4/docs.mql4.com/dateandtime/year.html
        /// </summary>
        public int Year (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Year, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountInfoDouble
        /// Description: Returns the value of the corresponding account property.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountinfodouble.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of the property. The value can be one of the values of .</param>
        public double AccountInfoDouble (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.AccountInfoDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountInfoInteger
        /// Description: Returns the value of the properties of the account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountinfointeger.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of the property. The value can be one of the values of .</param>
        public long AccountInfoInteger (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.AccountInfoInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountInfoString
        /// Description: Returns the value of the corresponding account property.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountinfostring.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of the property. The value can be one of the values of .</param>
        public string AccountInfoString (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.AccountInfoString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountBalance
        /// Description: Returns balance value of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountbalance.html
        /// </summary>
        public double AccountBalance (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountBalance, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountCredit
        /// Description: Returns credit value of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountcredit.html
        /// </summary>
        public double AccountCredit (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountCredit, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountCompany
        /// Description: Returns the brokerage company name where the current account was registered.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountcompany.html
        /// </summary>
        public string AccountCompany (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountCompany, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountCurrency
        /// Description: Returns currency name of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountcurrency.html
        /// </summary>
        public string AccountCurrency (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountCurrency, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountEquity
        /// Description: Returns equity value of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountequity.html
        /// </summary>
        public double AccountEquity (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountEquity, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountFreeMargin
        /// Description: Returns free margin value of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountfreemargin.html
        /// </summary>
        public double AccountFreeMargin (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountFreeMargin, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountFreeMarginCheck
        /// Description: Returns free margin that remains after the specified order has been opened at the current price on the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountfreemargincheck.html
        /// </summary>
        /// <param name="symbol">[in] Symbol for trading operation.</param>
        /// <param name="cmd">[in] Operation type. It can be either OP_BUY or OP_SELL.</param>
        /// <param name="volume">[in] Number of lots.</param>
        public double AccountFreeMarginCheck (string symbol, int cmd, double volume)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(cmd);
            parameters.Add(volume);
            
            CommandManager.getInstance().ExecCommand(Command.AccountFreeMarginCheck, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountFreeMarginMode
        /// Description: Returns the calculation mode of free margin allowed to open orders on the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountfreemarginmode.html
        /// </summary>
        public double AccountFreeMarginMode (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountFreeMarginMode, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountLeverage
        /// Description: Returns leverage of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountleverage.html
        /// </summary>
        public int AccountLeverage (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountLeverage, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountMargin
        /// Description: Returns margin value of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountmargin.html
        /// </summary>
        public double AccountMargin (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountMargin, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountName
        /// Description: Returns the current account name.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountname.html
        /// </summary>
        public string AccountName (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountNumber
        /// Description: Returns the current account number.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountnumber.html
        /// </summary>
        public int AccountNumber (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountNumber, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountProfit
        /// Description: Returns profit value of the current account.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountprofit.html
        /// </summary>
        public double AccountProfit (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountProfit, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountServer
        /// Description: Returns the connected server name.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountserver.html
        /// </summary>
        public string AccountServer (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountServer, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountStopoutLevel
        /// Description: Returns the value of the Stop Out level.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountstopoutlevel.html
        /// </summary>
        public int AccountStopoutLevel (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountStopoutLevel, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: AccountStopoutMode
        /// Description: Returns the calculation mode for the Stop Out level.
        /// URL: http://mm.l/mql4/docs.mql4.com/account/accountstopoutmode.html
        /// </summary>
        public int AccountStopoutMode (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.AccountStopoutMode, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GetLastError
        /// Description: Returns the contents of the
        /// URL: http://mm.l/mql4/docs.mql4.com/check/getlasterror.html
        /// </summary>
        public int GetLastError (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.GetLastError, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsStopped
        /// Description: Checks the forced shutdown of an mql4 program.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/isstopped.html
        /// </summary>
        public bool IsStopped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsStopped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: UninitializeReason
        /// Description: Returns the code of a
        /// URL: http://mm.l/mql4/docs.mql4.com/check/uninitializereason.html
        /// </summary>
        public int UninitializeReason (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.UninitializeReason, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MQLInfoInteger
        /// Description: Returns the value of a corresponding property of a running mql4 program.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/mqlinfointeger.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of a property. Can be one of values of the enumeration.</param>
        public int MQLInfoInteger (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.MQLInfoInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MQLInfoString
        /// Description: Returns the value of a corresponding property of a running MQL4 program.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/mqlinfostring.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of a property. Can be one of the enumeration.</param>
        public string MQLInfoString (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.MQLInfoString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MQLSetInteger
        /// Description: Sets the value of the
        /// URL: http://mm.l/mql4/docs.mql4.com/check/mqlsetinteger.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of a property. Only is supported, as other properties cannot be changed.</param>
        /// <param name="property_value">[in] Value of property. Can be one of the .</param>
        public void MQLSetInteger (int property_id, int property_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            parameters.Add(property_value);
            
            CommandManager.getInstance().ExecCommand(Command.MQLSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TerminalInfoInteger
        /// Description: Returns the value of a corresponding property of the mql4 program environment.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/terminalinfointeger.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of a property. Can be one of the values of the enumeration.</param>
        public int TerminalInfoInteger (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.TerminalInfoInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TerminalInfoDouble
        /// Description: Returns the value of a corresponding property of the mql4 program environment.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/terminalinfodouble.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of a property. Can be one of the values of the enumeration.</param>
        public double TerminalInfoDouble (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.TerminalInfoDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TerminalInfoString
        /// Description: Returns the value of a corresponding property of the mql4 program environment. The property must be of string type.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/terminalinfostring.html
        /// </summary>
        /// <param name="property_id">[in] Identifier of a property. Can be one of the values of the enumeration.</param>
        public string TerminalInfoString (int property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.TerminalInfoString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Symbol
        /// Description: Returns the name of a symbol of the current chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/symbol.html
        /// </summary>
        public string Symbol (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Symbol, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Period
        /// Description: Returns the current chart timeframe.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/period.html
        /// </summary>
        public int Period (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Period, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Digits
        /// Description: Returns the number of decimal digits determining the accuracy of price of the current chart symbol.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/digits.html
        /// </summary>
        public int Digits (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Digits, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Point
        /// Description: Returns the point size of the current symbol in the quote currency.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/point.html
        /// </summary>
        public double Point (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Point, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsConnected
        /// Description: Checks connection between client terminal and server.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/isconnected.html
        /// </summary>
        public bool IsConnected (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsConnected, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsDemo
        /// Description: Checks if the Expert Advisor runs on a demo account.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/isdemo.html
        /// </summary>
        public bool IsDemo (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsDemo, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsDllsAllowed
        /// Description: Checks if the DLL function call is allowed for the Expert Advisor.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/isdllsallowed.html
        /// </summary>
        public bool IsDllsAllowed (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsDllsAllowed, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsExpertEnabled
        /// Description: Checks if Expert Advisors are enabled for running.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/isexpertenabled.html
        /// </summary>
        public bool IsExpertEnabled (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsExpertEnabled, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsLibrariesAllowed
        /// Description: Checks if the Expert Advisor can call library function.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/islibrariesallowed.html
        /// </summary>
        public bool IsLibrariesAllowed (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsLibrariesAllowed, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsOptimization
        /// Description: Checks if Expert Advisor runs in the Strategy Tester optimization mode.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/isoptimization.html
        /// </summary>
        public bool IsOptimization (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsOptimization, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsTesting
        /// Description: Checks
        /// URL: http://mm.l/mql4/docs.mql4.com/check/istesting.html
        /// </summary>
        public bool IsTesting (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsTesting, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsTradeAllowed
        /// Description: Checks
        /// URL: http://mm.l/mql4/docs.mql4.com/check/istradeallowed.html
        /// </summary>
        public bool IsTradeAllowed (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsTradeAllowed, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsTradeAllowed
        /// Description: Checks
        /// URL: http://mm.l/mql4/docs.mql4.com/check/istradeallowed.html
        /// </summary>
        /// <param name="symbol">[in] Symbol.</param>
        /// <param name="tested_time">[in] Time to check status.</param>
        public bool IsTradeAllowed (const string symbol, datetime tested_time)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(tested_time);
            
            CommandManager.getInstance().ExecCommand(Command.IsTradeAllowed, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsTradeContextBusy
        /// Description: Returns the information about trade context.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/istradecontextbusy.html
        /// </summary>
        public bool IsTradeContextBusy (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsTradeContextBusy, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IsVisualMode
        /// Description: Checks
        /// URL: http://mm.l/mql4/docs.mql4.com/check/isvisualmode.html
        /// </summary>
        public bool IsVisualMode (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IsVisualMode, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TerminalCompany
        /// Description: Returns the name of company owning the client terminal.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/terminalcompany.html
        /// </summary>
        public string TerminalCompany (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TerminalCompany, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TerminalName
        /// Description: Returns client terminal name.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/terminalname.html
        /// </summary>
        public string TerminalName (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TerminalName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TerminalPath
        /// Description: Returns the directory, from which the client terminal was launched.
        /// URL: http://mm.l/mql4/docs.mql4.com/check/terminalpath.html
        /// </summary>
        public string TerminalPath (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.TerminalPath, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: MarketInfo
        /// Description: Returns various data about securities listed in the "Market Watch" window.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/marketinfo.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name.</param>
        /// <param name="type">[in] Request of information to be returned. Can be any of values of request identifiers.</param>
        public double MarketInfo (string symbol, int type)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(type);
            
            CommandManager.getInstance().ExecCommand(Command.MarketInfo, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolsTotal
        /// Description: Returns the number of available (selected in Market Watch or all) symbols.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolstotal.html
        /// </summary>
        /// <param name="selected">[in] Request mode. Can be true or false.</param>
        public int SymbolsTotal (bool selected)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(selected);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolsTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolName
        /// Description: Returns the name of a symbol.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolname.html
        /// </summary>
        /// <param name="pos">[in] Order number of a symbol.</param>
        /// <param name="selected">[in] Request mode. If the value is true, the symbol is taken from the list of symbols selected in MarketWatch. If the value is false, the symbol is taken from the general list.</param>
        public string SymbolName (int pos, bool selected)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(pos);
            parameters.Add(selected);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolSelect
        /// Description: Selects a symbol in the Market Watch window or removes a symbol from the window.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolselect.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="select">[in] Switch. If the value is false, a symbol should be removed from MarketWatch, otherwise a symbol should be selected in this window. A symbol can't be removed if the symbol chart is open, or there are open orders for this symbol.</param>
        public bool SymbolSelect (string name, bool select)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(select);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolSelect, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoDouble
        /// Description: Returns the corresponding property of a specified symbol. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfodouble.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="prop_id">[in] Identifier of a symbol property. The value can be one of the values of the enumeration.</param>
        public double SymbolInfoDouble (string name, ENUM_SYMBOL_INFO_DOUBLE prop_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(prop_id);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoDouble
        /// Description: Returns the corresponding property of a specified symbol. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfodouble.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="prop_id">[in] Identifier of a symbol property. The value can be one of the values of the enumeration.</param>
        /// <param name="double_var">[out] Variable of double type receiving the value of the requested property.</param>
        public bool SymbolInfoDouble (string name, ENUM_SYMBOL_INFO_DOUBLE prop_id, double& double_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(prop_id);
            parameters.Add(double_var);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoInteger
        /// Description: Returns the corresponding property of a specified symbol. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfointeger.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="prop_id">[in] Identifier of a symbol property. The value can be one of the values of the enumeration.</param>
        public long SymbolInfoInteger (string name, ENUM_SYMBOL_INFO_INTEGER prop_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(prop_id);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoInteger
        /// Description: Returns the corresponding property of a specified symbol. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfointeger.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="prop_id">[in] Identifier of a symbol property. The value can be one of the values of the enumeration.</param>
        /// <param name="long_var">[out] Variable of the long type receiving the value of the requested property.</param>
        public bool SymbolInfoInteger (string name, ENUM_SYMBOL_INFO_INTEGER prop_id, long& long_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(prop_id);
            parameters.Add(long_var);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoString
        /// Description: Returns the corresponding property of a specified symbol. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfostring.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="prop_id">[in] Identifier of a symbol property. The value can be one of the values of the enumeration.</param>
        public string SymbolInfoString (string name, ENUM_SYMBOL_INFO_STRING prop_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(prop_id);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoString
        /// Description: Returns the corresponding property of a specified symbol. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfostring.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="prop_id">[in] Identifier of a symbol property. The value can be one of the values of the enumeration.</param>
        /// <param name="string_var">[out] Variable of the string type receiving the value of the requested property.</param>
        public bool SymbolInfoString (string name, ENUM_SYMBOL_INFO_STRING prop_id, string& string_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(prop_id);
            parameters.Add(string_var);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoTick
        /// Description: The function returns current prices of a specified symbol in a variable of the MqlTick type.
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfotick.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name.</param>
        /// <param name="tick">[out] Link to the structure of the type, to which the current prices and time of the last price update will be placed.</param>
        public bool SymbolInfoTick (string symbol, MqlTick& tick)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(tick);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoTick, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoSessionQuote
        /// Description: Allows receiving time of beginning and end of the specified quoting sessions for a specified symbol and d
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfosessionquote.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="day_of_week"></param>
        /// <param name="session_index"></param>
        /// <param name="from">[out] Session beginning time in seconds from 00 hours 00 minutes, in the returned value date should be ignored.</param>
        /// <param name="to">[out] Session end time in seconds from 00 hours 00 minutes, in the returned value date should be ignored.</param>
        public bool SymbolInfoSessionQuote (string name, ENUM_DAY_OF_WEEK day_of_week, uint session_index, datetime& from, datetime& to)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(day_of_week);
            parameters.Add(session_index);
            parameters.Add(from);
            parameters.Add(to);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoSessionQuote, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SymbolInfoSessionTrade
        /// Description: Allows receiving time of beginning and end of the specified trading sessions for a specified symbol and d
        /// URL: http://mm.l/mql4/docs.mql4.com/marketinformation/symbolinfosessiontrade.html
        /// </summary>
        /// <param name="name">[in] Symbol name.</param>
        /// <param name="day_of_week"></param>
        /// <param name="session_index"></param>
        /// <param name="from">[out] Session beginning time in seconds from 00 hours 00 minutes, in the returned value date should be ignored.</param>
        /// <param name="to">[out] Session end time in seconds from 00 hours 00 minutes, in the returned value date should be ignored.</param>
        public bool SymbolInfoSessionTrade (string name, ENUM_DAY_OF_WEEK day_of_week, uint session_index, datetime& from, datetime& to)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(day_of_week);
            parameters.Add(session_index);
            parameters.Add(from);
            parameters.Add(to);
            
            CommandManager.getInstance().ExecCommand(Command.SymbolInfoSessionTrade, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SeriesInfoInteger
        /// Description: Returns information about the state of historical data. There are 2 variants of function calls.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/seriesinfointeger.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="prop_id">[in] Identifier of the requested property, value of the enumeration.</param>
        public long SeriesInfoInteger (string symbol_name, ENUM_TIMEFRAMES timeframe, ENUM_SERIES_INFO_INTEGER prop_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(prop_id);
            
            CommandManager.getInstance().ExecCommand(Command.SeriesInfoInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SeriesInfoInteger
        /// Description: Returns information about the state of historical data. There are 2 variants of function calls.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/seriesinfointeger.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="prop_id">[in] Identifier of the requested property, value of the enumeration.</param>
        /// <param name="long_var">[out] Variable to which the value of the requested property is placed.</param>
        public bool SeriesInfoInteger (string symbol_name, ENUM_TIMEFRAMES timeframe, ENUM_SERIES_INFO_INTEGER prop_id, long& long_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(prop_id);
            parameters.Add(long_var);
            
            CommandManager.getInstance().ExecCommand(Command.SeriesInfoInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: RefreshRates
        /// Description: Refreshing of data in pre-defined variables and series arrays.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/refreshrates.html
        /// </summary>
        public bool RefreshRates (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.RefreshRates, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyRates
        /// Description: Gets history data of
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyrates.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_pos">[in] The start position for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="rates_array[]">[out] Array of type.</param>
        public int CopyRates (string symbol_name, ENUM_TIMEFRAMES timeframe, int start_pos, int count, MqlRates rates_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_pos);
            parameters.Add(count);
            parameters.Add(rates_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyRates, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyRates
        /// Description: Gets history data of
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyrates.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] Bar time for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="rates_array[]">[out] Array of type.</param>
        public int CopyRates (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, int count, MqlRates rates_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(count);
            parameters.Add(rates_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyRates, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyRates
        /// Description: Gets history data of
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyrates.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] Bar time for the first element to copy.</param>
        /// <param name="stop_time">[in] Bar time, corresponding to the last element to copy.</param>
        /// <param name="rates_array[]">[out] Array of type.</param>
        public int CopyRates (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time, MqlRates rates_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            parameters.Add(rates_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyRates, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyTime
        /// Description: The function gets to time_array history data of bar opening time for the specified symbol-period pair in the specified quantity. It should be noted that elements ordering
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copytime.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_pos">[in] The start position for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="time_array[]">[out] Array of type.</param>
        public int CopyTime (string symbol_name, ENUM_TIMEFRAMES timeframe, int start_pos, int count, datetime time_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_pos);
            parameters.Add(count);
            parameters.Add(time_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyTime
        /// Description: The function gets to time_array history data of bar opening time for the specified symbol-period pair in the specified quantity. It should be noted that elements ordering
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copytime.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="time_array[]">[out] Array of type.</param>
        public int CopyTime (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, int count, datetime time_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(count);
            parameters.Add(time_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyTime
        /// Description: The function gets to time_array history data of bar opening time for the specified symbol-period pair in the specified quantity. It should be noted that elements ordering
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copytime.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="stop_time">[in] Bar time corresponding to the last element to copy.</param>
        /// <param name="time_array[]">[out] Array of type.</param>
        public int CopyTime (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time, datetime time_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            parameters.Add(time_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyOpen
        /// Description: The function gets into open_array the history data of bar open prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyopen.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_pos">[in] The start position for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="open_array[]">[out] Array of type.</param>
        public int CopyOpen (string symbol_name, ENUM_TIMEFRAMES timeframe, int start_pos, int count, double open_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_pos);
            parameters.Add(count);
            parameters.Add(open_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyOpen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyOpen
        /// Description: The function gets into open_array the history data of bar open prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyopen.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="open_array[]">[out] Array of type.</param>
        public int CopyOpen (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, int count, double open_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(count);
            parameters.Add(open_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyOpen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyOpen
        /// Description: The function gets into open_array the history data of bar open prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyopen.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="stop_time">[in] The start time for the last element to copy.</param>
        /// <param name="open_array[]">[out] Array of type.</param>
        public int CopyOpen (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time, double open_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            parameters.Add(open_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyOpen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyHigh
        /// Description: The function gets into high_array the history data of highest bar prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyhigh.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_pos">[in] The start position for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="high_array[]">[out] Array of type.</param>
        public int CopyHigh (string symbol_name, ENUM_TIMEFRAMES timeframe, int start_pos, int count, double high_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_pos);
            parameters.Add(count);
            parameters.Add(high_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyHigh, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyHigh
        /// Description: The function gets into high_array the history data of highest bar prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyhigh.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="high_array[]">[out] Array of type.</param>
        public int CopyHigh (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, int count, double high_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(count);
            parameters.Add(high_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyHigh, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyHigh
        /// Description: The function gets into high_array the history data of highest bar prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyhigh.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="stop_time">[in] Bar time, corresponding to the last element to copy.</param>
        /// <param name="high_array[]">[out] Array of type.</param>
        public int CopyHigh (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time, double high_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            parameters.Add(high_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyHigh, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyLow
        /// Description: The function gets into low_array the history data of minimal bar prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copylow.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_pos">[in] The start position for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="low_array[]">[out] Array of type.</param>
        public int CopyLow (string symbol_name, ENUM_TIMEFRAMES timeframe, int start_pos, int count, double low_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_pos);
            parameters.Add(count);
            parameters.Add(low_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyLow, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyLow
        /// Description: The function gets into low_array the history data of minimal bar prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copylow.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] Bar time, corresponding to the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="low_array[]">[out] Array of type.</param>
        public int CopyLow (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, int count, double low_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(count);
            parameters.Add(low_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyLow, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyLow
        /// Description: The function gets into low_array the history data of minimal bar prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copylow.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] Bar time, corresponding to the first element to copy.</param>
        /// <param name="stop_time">[in] Bar time, corresponding to the last element to copy.</param>
        /// <param name="low_array[]">[out] Array of type.</param>
        public int CopyLow (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time, double low_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            parameters.Add(low_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyLow, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyClose
        /// Description: The function gets into close_array the history data of bar close prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyclose.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_pos">[in] The start position for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="close_array[]">[out] Array of type.</param>
        public int CopyClose (string symbol_name, ENUM_TIMEFRAMES timeframe, int start_pos, int count, double close_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_pos);
            parameters.Add(count);
            parameters.Add(close_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyClose
        /// Description: The function gets into close_array the history data of bar close prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyclose.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="close_array[]">[out] Array of type.</param>
        public int CopyClose (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, int count, double close_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(count);
            parameters.Add(close_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyClose
        /// Description: The function gets into close_array the history data of bar close prices for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copyclose.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="stop_time">[in] Bar time, corresponding to the last element to copy.</param>
        /// <param name="close_array[]">[out] Array of type.</param>
        public int CopyClose (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time, double close_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            parameters.Add(close_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyTickVolume
        /// Description: The function gets into volume_array the history data of tick volumes for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copytickvolume.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_pos">[in] The start position for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="volume_array[]">[out] Array of type.</param>
        public int CopyTickVolume (string symbol_name, ENUM_TIMEFRAMES timeframe, int start_pos, int count, long volume_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_pos);
            parameters.Add(count);
            parameters.Add(volume_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyTickVolume, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyTickVolume
        /// Description: The function gets into volume_array the history data of tick volumes for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copytickvolume.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="count">[in] Data count to copy.</param>
        /// <param name="volume_array[]">[out] Array of type.</param>
        public int CopyTickVolume (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, int count, long volume_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(count);
            parameters.Add(volume_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyTickVolume, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: CopyTickVolume
        /// Description: The function gets into volume_array the history data of tick volumes for the selected symbol-period pair in the specified quantity. It should be noted that elements ordering is from present to past, i.e., starting position of 0 means the current bar.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/copytickvolume.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] The start time for the first element to copy.</param>
        /// <param name="stop_time">[in] Bar time, corresponding to the last element to copy.</param>
        /// <param name="volume_array[]">[out] Array of type.</param>
        public int CopyTickVolume (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time, long volume_array[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            parameters.Add(volume_array[]);
            
            CommandManager.getInstance().ExecCommand(Command.CopyTickVolume, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Bars
        /// Description: Returns the number of bars count in the history for a specified symbol and period. There are 2 variants of functions calls.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/barsfunction.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        public int Bars (string symbol_name, ENUM_TIMEFRAMES timeframe)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            
            CommandManager.getInstance().ExecCommand(Command.Bars, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Bars
        /// Description: Returns the number of bars count in the history for a specified symbol and period. There are 2 variants of functions calls.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/barsfunction.html
        /// </summary>
        /// <param name="symbol_name">[in] Symbol name.</param>
        /// <param name="timeframe">[in] Period.</param>
        /// <param name="start_time">[in] Bar time corresponding to the first element.</param>
        /// <param name="stop_time">[in] Bar time corresponding to the last element.</param>
        public int Bars (string symbol_name, ENUM_TIMEFRAMES timeframe, datetime start_time, datetime stop_time)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol_name);
            parameters.Add(timeframe);
            parameters.Add(start_time);
            parameters.Add(stop_time);
            
            CommandManager.getInstance().ExecCommand(Command.Bars, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iBars
        /// Description: Returns the number of bars on the specified chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/ibars.html
        /// </summary>
        /// <param name="symbol">[in] Symbol the data of which should be used to calculate indicator. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        public int iBars (string symbol, int timeframe)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            
            CommandManager.getInstance().ExecCommand(Command.iBars, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iBarShift
        /// Description: Search for a bar by its time. The function returns the index of the bar which covers the specified time.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/ibarshift.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="time">[in] Time value for searching.</param>
        /// <param name="exact">[in] Return mode when the bar is not found (false - iBarShift returns the nearest, true - iBarShift returns -1).</param>
        public int iBarShift (string symbol, int timeframe, datetime time, bool exact)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(time);
            parameters.Add(exact);
            
            CommandManager.getInstance().ExecCommand(Command.iBarShift, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iClose
        /// Description: Returns Close price value for the bar of specified symbol with timeframe and shift.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/iclose.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iClose (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iHigh
        /// Description: Returns High price value for the bar of specified symbol with timeframe and shift.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/ihigh.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iHigh (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iHigh, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iHighest
        /// Description: Returns the shift of the maximum value over a specific number of bars depending on type.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/ihighest.html
        /// </summary>
        /// <param name="symbol">[in] Symbol the data of which should be used for search. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="type">[in] Series array identifier. It can be any of the enumeration values.</param>
        /// <param name="count">[in] Number of bars (in direction from the start bar to the back one) on which the search is carried out.</param>
        /// <param name="start">[in] Shift showing the bar, relative to the current bar, that the data should be taken from.</param>
        public int iHighest (string symbol, int timeframe, int type, int count, int start)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(type);
            parameters.Add(count);
            parameters.Add(start);
            
            CommandManager.getInstance().ExecCommand(Command.iHighest, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iLow
        /// Description: Returns Low price value for the bar of indicated symbol with timeframe and shift.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/ilow.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iLow (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iLow, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iLowest
        /// Description: Returns the shift of the lowest value over a specific number of bars depending on type.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/ilowest.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="type">[in] Series array identifier. It can be any of the enumeration values.</param>
        /// <param name="count">[in] Number of bars (in direction from the start bar to the back one) on which the search is carried out.</param>
        /// <param name="start">[in] Shift showing the bar, relative to the current bar, that the data should be taken from.</param>
        public int iLowest (string symbol, int timeframe, int type, int count, int start)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(type);
            parameters.Add(count);
            parameters.Add(start);
            
            CommandManager.getInstance().ExecCommand(Command.iLowest, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iOpen
        /// Description: Returns Open price value for the bar of specified symbol with timeframe and shift.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/iopen.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iOpen (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iOpen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iTime
        /// Description: Returns Time value for the bar of specified symbol with timeframe and shift.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/itime.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public datetime iTime (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iVolume
        /// Description: Returns Tick Volume value for the bar of specified symbol with timeframe and shift.
        /// URL: http://mm.l/mql4/docs.mql4.com/series/ivolume.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public long iVolume (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iVolume, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartApplyTemplate
        /// Description: Applies a specific template from a specified file to the chart. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartapplytemplate.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="filename">[in] The name of the file containing the template.</param>
        public bool ChartApplyTemplate (long chart_id, const string filename)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(filename);
            
            CommandManager.getInstance().ExecCommand(Command.ChartApplyTemplate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartSaveTemplate
        /// Description: Saves current chart settings in a template with a specified name. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartsavetemplate.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="filename">[in] The filename to save the template. The ".tpl" extension will be added to the filename automatically; there is no need to specify it. The template is saved in terminal_directory\Profiles\Templates\ and can be used for manual application in the terminal. If a template with the same filename already exists, the contents of this file will be overwritten.</param>
        public bool ChartSaveTemplate (long chart_id, const string filename)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(filename);
            
            CommandManager.getInstance().ExecCommand(Command.ChartSaveTemplate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartWindowFind
        /// Description: The function returns the number of a subwindow where an indicator is drawn. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartwindowfind.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 denotes the current chart.</param>
        /// <param name="indicator_shortname">[in] Short name of the indicator.</param>
        public int ChartWindowFind (long chart_id, string indicator_shortname)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(indicator_shortname);
            
            CommandManager.getInstance().ExecCommand(Command.ChartWindowFind, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartWindowFind
        /// Description: The function returns the number of a subwindow where an indicator is drawn. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartwindowfind.html
        /// </summary>
        public int ChartWindowFind (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartWindowFind, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartTimePriceToXY
        /// Description: Converts the coordinates of a chart from the time/price representation to the X and Y coordinates.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/charttimepricetoxy.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="sub_window">[in] The number of the chart subwindow. 0 means the main chart window.</param>
        /// <param name="time">[in] The time value on the chart, for which the value in pixels along the X axis will be received.</param>
        /// <param name="price">[in] The price value on the chart, for which the value in pixels along the Y axis will be received.</param>
        /// <param name="x">[out] The variable, into which the conversion of time to X will be received. The origin is in the upper left corner of the main chart window.</param>
        /// <param name="y">[out] The variable, into which the conversion of price to Y will be received. The origin is in the upper left corner of the main chart window.</param>
        public bool ChartTimePriceToXY (long chart_id, int sub_window, datetime time, double price, int& x, int& y)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(sub_window);
            parameters.Add(time);
            parameters.Add(price);
            parameters.Add(x);
            parameters.Add(y);
            
            CommandManager.getInstance().ExecCommand(Command.ChartTimePriceToXY, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartXYToTimePrice
        /// Description: Converts the X and Y coordinates on a chart to the time and price values.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartxytotimeprice.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="x">[in] The X coordinate. The origin is in the upper left corner of the main chart window.</param>
        /// <param name="y">[in] The Y coordinate. The origin is in the upper left corner of the main chart window.</param>
        /// <param name="sub_window">[out] The variable, into which the chart subwindow number will be written. 0 means the main chart window.</param>
        /// <param name="time">[out] The time value on the chart, for which the value in pixels along the X axis will be received.</param>
        /// <param name="price">[out] The price value on the chart, for which the value in pixels along the Y axis will be received.</param>
        public bool ChartXYToTimePrice (long chart_id, int x, int y, int& sub_window, datetime& time, double& price)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(x);
            parameters.Add(y);
            parameters.Add(sub_window);
            parameters.Add(time);
            parameters.Add(price);
            
            CommandManager.getInstance().ExecCommand(Command.ChartXYToTimePrice, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartOpen
        /// Description: Opens a new chart with the specified symbol and period. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartopen.html
        /// </summary>
        /// <param name="symbol">[in] Chart symbol. means the symbol of the current chart (the Expert Advisor is attached to).</param>
        /// <param name="period">[in] Chart period (timeframe). Can be one of the values. 0 means the current chart period.</param>
        public long ChartOpen (string symbol, ENUM_TIMEFRAMES period)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(period);
            
            CommandManager.getInstance().ExecCommand(Command.ChartOpen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartFirst
        /// Description: Returns the ID of the first chart of the client terminal.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartfirst.html
        /// </summary>
        public long ChartFirst (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartFirst, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartNext
        /// Description: Returns the chart ID of the chart next to the specified one.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartnext.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 does not mean the current chart. 0 means "return the first chart ID".</param>
        public long ChartNext (long chart_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            
            CommandManager.getInstance().ExecCommand(Command.ChartNext, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartClose
        /// Description: Closes the specified chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartclose.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        public bool ChartClose (long chart_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            
            CommandManager.getInstance().ExecCommand(Command.ChartClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartSymbol
        /// Description: Returns the symbol name for the specified chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartsymbol.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        public string ChartSymbol (long chart_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            
            CommandManager.getInstance().ExecCommand(Command.ChartSymbol, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartPeriod
        /// Description: Returns the timeframe
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartperiod.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        public ENUM_TIMEFRAMES ChartPeriod (long chart_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            
            CommandManager.getInstance().ExecCommand(Command.ChartPeriod, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (ENUM_TIMEFRAMES) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartRedraw
        /// Description: This function calls a forced redrawing of a specified chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartredraw.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        public void ChartRedraw (long chart_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            
            CommandManager.getInstance().ExecCommand(Command.ChartRedraw, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartSetDouble
        /// Description: Sets a value for a corresponding property of the specified chart. Chart property should be of a
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartsetdouble.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. Can be one of the values (except the read-only properties).</param>
        /// <param name="value">[in] Property value.</param>
        public bool ChartSetDouble (long chart_id, int prop_id, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ChartSetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartSetInteger
        /// Description: Sets a value for a corresponding property of the specified chart. Chart property must be
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartsetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. It can be one of the value (except the read-only properties).</param>
        /// <param name="value">[in] Property value.</param>
        public bool ChartSetInteger (long chart_id, int prop_id, long value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ChartSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartSetInteger
        /// Description: Sets a value for a corresponding property of the specified chart. Chart property must be
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartsetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="property_id"></param>
        /// <param name="sub_window">[in] Chart subwindow.</param>
        /// <param name="value">[in] Property value.</param>
        public bool ChartSetInteger (long chart_id, int property_id, uint sub_window, long value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(property_id);
            parameters.Add(sub_window);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ChartSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartSetString
        /// Description: Sets a value for a corresponding property of the specified chart. Chart property must be of the string type. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartsetstring.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. Its value can be one of the values (except the read-only properties).</param>
        /// <param name="str_value">[in] Property value string. String length cannot exceed 2045 characters (extra characters will be truncated).</param>
        public bool ChartSetString (long chart_id, int prop_id, string str_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(str_value);
            
            CommandManager.getInstance().ExecCommand(Command.ChartSetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartGetDouble
        /// Description: Returns the value of a corresponding property of the specified chart. Chart property must be of double type. There are 2 variants of the function calls.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartgetdouble.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. This value can be one of the values.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. For the first case, the default value is 0 (main chart window). The most of the properties do not require a subwindow number.</param>
        public double ChartGetDouble (long chart_id, int prop_id, int sub_window)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(sub_window);
            
            CommandManager.getInstance().ExecCommand(Command.ChartGetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartGetDouble
        /// Description: Returns the value of a corresponding property of the specified chart. Chart property must be of double type. There are 2 variants of the function calls.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartgetdouble.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. This value can be one of the values.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. For the first case, the default value is 0 (main chart window). The most of the properties do not require a subwindow number.</param>
        /// <param name="double_var">[out] Target variable of double type for the requested property.</param>
        public bool ChartGetDouble (long chart_id, int prop_id, int sub_window, double& double_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(sub_window);
            parameters.Add(double_var);
            
            CommandManager.getInstance().ExecCommand(Command.ChartGetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartGetInteger
        /// Description: Returns the value of a corresponding property of the specified chart. Chart property must be of
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartgetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. This value can be one of the values.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. For the first case, the default value is 0 (main chart window). The most of the properties do not require a subwindow number.</param>
        public long ChartGetInteger (long chart_id, int prop_id, int sub_window)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(sub_window);
            
            CommandManager.getInstance().ExecCommand(Command.ChartGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartGetInteger
        /// Description: Returns the value of a corresponding property of the specified chart. Chart property must be of
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartgetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. This value can be one of the values.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. For the first case, the default value is 0 (main chart window). The most of the properties do not require a subwindow number.</param>
        /// <param name="long_var">[out] Target variable of long type for the requested property.</param>
        public bool ChartGetInteger (long chart_id, int prop_id, int sub_window, long& long_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(sub_window);
            parameters.Add(long_var);
            
            CommandManager.getInstance().ExecCommand(Command.ChartGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartGetString
        /// Description: Returns the value of a corresponding property of the specified chart. Chart property must be of string type. There are 2 variants of the function call.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartgetstring.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. This value can be one of the values.</param>
        public string ChartGetString (long chart_id, int prop_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            
            CommandManager.getInstance().ExecCommand(Command.ChartGetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartGetString
        /// Description: Returns the value of a corresponding property of the specified chart. Chart property must be of string type. There are 2 variants of the function call.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartgetstring.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="prop_id">[in] Chart property ID. This value can be one of the values.</param>
        /// <param name="string_var">[out] Target variable of string type for the requested property.</param>
        public bool ChartGetString (long chart_id, int prop_id, string& string_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prop_id);
            parameters.Add(string_var);
            
            CommandManager.getInstance().ExecCommand(Command.ChartGetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartNavigate
        /// Description: Performs shift of the specified chart by the specified number of bars relative to the specified position in the chart. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartnavigate.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="position">[in] Chart position to perform a shift. Can be one of the values.</param>
        /// <param name="shift">[in] Number of bars to shift the chart. Positive value means the right shift (to the end of chart), negative value means the left shift (to the beginning of chart). The zero shift can be used to navigate to the beginning or end of chart.</param>
        public bool ChartNavigate (long chart_id, int position, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(position);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.ChartNavigate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartID
        /// Description: Returns the ID of the current chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartid.html
        /// </summary>
        public long ChartID (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartID, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartIndicatorDelete
        /// Description: Removes an indicator with a specified name from the specified chart window. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartindicatordelete.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 denotes the current chart.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. 0 denotes the main chart subwindow.</param>
        /// <param name="indicator_shortname"></param>
        public bool ChartIndicatorDelete (long chart_id, int sub_window, const string indicator_shortname)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(sub_window);
            parameters.Add(indicator_shortname);
            
            CommandManager.getInstance().ExecCommand(Command.ChartIndicatorDelete, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartIndicatorName
        /// Description: Returns the short name of the indicator by the number in the indicators list on the specified chart window.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartindicatorname.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 denotes the current chart.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. 0 denotes the main chart subwindow.</param>
        /// <param name="index">[in] the index of the indicator in the list of indicators. The numeration of indicators start with zero, i.e. the first indicator in the list has the 0 index. To obtain the number of indicators in the list use the function.</param>
        public string ChartIndicatorName (long chart_id, int sub_window, int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(sub_window);
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.ChartIndicatorName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartIndicatorsTotal
        /// Description: Returns the number of all indicators applied to the specified chart window.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartindicatorstotal.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 denotes the current chart.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. 0 denotes the main chart subwindow.</param>
        public int ChartIndicatorsTotal (long chart_id, int sub_window)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(sub_window);
            
            CommandManager.getInstance().ExecCommand(Command.ChartIndicatorsTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartWindowOnDropped
        /// Description: Returns the number (index) of the chart subwindow the Expert Advisor or script has been dropped to. 0 means the main chart window.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartwindowondropped.html
        /// </summary>
        public int ChartWindowOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartWindowOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartPriceOnDropped
        /// Description: Returns the price coordinate corresponding to the chart point the Expert Advisor or script has been dropped to.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartpriceondropped.html
        /// </summary>
        public double ChartPriceOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartPriceOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartTimeOnDropped
        /// Description: Returns the time coordinate corresponding to the chart point the Expert Advisor or script has been dropped to.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/charttimeondropped.html
        /// </summary>
        public datetime ChartTimeOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartTimeOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartXOnDropped
        /// Description: Returns the X coordinate of the chart point the Expert Advisor or script has been dropped to.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartxondropped.html
        /// </summary>
        public int ChartXOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartXOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartYOnDropped
        /// Description: Returns the Y coordinateof the chart point the Expert Advisor or script has been dropped to.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartyondropped.html
        /// </summary>
        public int ChartYOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.ChartYOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartSetSymbolPeriod
        /// Description: Changes the symbol and period of the specified chart. The function is asynchronous, i.e. it sends the command and does not wait for its execution completion. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartsetsymbolperiod.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="symbol">[in] Chart symbol. value means the current chart symbol (Expert Advisor is attached to)</param>
        /// <param name="period">[in] Chart period (timeframe). Can be one of the values. 0 means the current chart period.</param>
        public bool ChartSetSymbolPeriod (long chart_id, string symbol, ENUM_TIMEFRAMES period)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(symbol);
            parameters.Add(period);
            
            CommandManager.getInstance().ExecCommand(Command.ChartSetSymbolPeriod, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ChartScreenShot
        /// Description: Saves current chart screen shot as a GIF, PNG or BMP file depending on specified extension. The command is added to chart message queue and executed only after all previous commands have been processed.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/chartscreenshot.html
        /// </summary>
        /// <param name="chart_id">[in] Chart ID. 0 means the current chart.</param>
        /// <param name="filename">[in] Screenshot file name. Cannot exceed 63 characters. Screenshot files are placed in the \Files directory.</param>
        /// <param name="width">[in] Screenshot width in pixels.</param>
        /// <param name="height">[in] Screenshot height in pixels.</param>
        /// <param name="align_mode">[in] Output mode of a narrow screenshot. A value of the enumeration. ALIGN_RIGHT means align to the right margin (the output from the end). ALIGN_LEFT means Left justify.</param>
        public bool ChartScreenShot (long chart_id, string filename, int width, int height, ENUM_ALIGN_MODE align_mode)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(filename);
            parameters.Add(width);
            parameters.Add(height);
            parameters.Add(align_mode);
            
            CommandManager.getInstance().ExecCommand(Command.ChartScreenShot, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Period
        /// Description: Returns timeframe of the current chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/periodwindow.html
        /// </summary>
        public int Period (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Period, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: Symbol
        /// Description: Returns a text string with the name of the current financial instrument.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/symbolwindow.html
        /// </summary>
        public string Symbol (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.Symbol, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowBarsPerChart
        /// Description: Returns the amount of bars visible on the chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowbarsperchart.html
        /// </summary>
        public int WindowBarsPerChart (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowBarsPerChart, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowExpertName
        /// Description: Returns the name of the executed Expert Advisor, script, custom indicator, or library.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowexpertname.html
        /// </summary>
        public string WindowExpertName (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowExpertName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowFind
        /// Description: Returns the window index containing this specified indicator.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowfind.html
        /// </summary>
        /// <param name="name">[in] Indicator short name.</param>
        public int WindowFind (string name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            
            CommandManager.getInstance().ExecCommand(Command.WindowFind, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowFirstVisibleBar
        /// Description: Returns index of the first visible bar in the current chart window.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowfirstvisiblebar.html
        /// </summary>
        public int WindowFirstVisibleBar (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowFirstVisibleBar, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowHandle
        /// Description: Returns the system handle of the chart window.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowhandle.html
        /// </summary>
        /// <param name="symbol">[in] Symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        public int WindowHandle (string symbol, int timeframe)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            
            CommandManager.getInstance().ExecCommand(Command.WindowHandle, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowIsVisible
        /// Description: Returns the visibility flag of the chart subwindow.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowisvisible.html
        /// </summary>
        /// <param name="index">[in] Subwindow index.</param>
        public int WindowIsVisible (int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.WindowIsVisible, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowOnDropped
        /// Description: Returns the window index where Expert Advisor, custom indicator or script was dropped.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowondropped.html
        /// </summary>
        public int WindowOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowPriceMax
        /// Description: Returns the maximal value of the vertical scale of the specified subwindow of the current chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowpricemax.html
        /// </summary>
        /// <param name="index">[in] Chart subwindow index (0 - main chart window).</param>
        public int WindowPriceMax (int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.WindowPriceMax, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowPriceMin
        /// Description: Returns the minimal value of the vertical scale of the specified subwindow of the current chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowpricemin.html
        /// </summary>
        /// <param name="index">[in] Chart subwindow index (0 - main chart window).</param>
        public int WindowPriceMin (int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.WindowPriceMin, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowPriceOnDropped
        /// Description: Returns the price of the chart point where Expert Advisor or script was dropped.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowpriceondropped.html
        /// </summary>
        public double WindowPriceOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowPriceOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowRedraw
        /// Description: Redraws the current chart forcedly.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowredraw.html
        /// </summary>
        public void WindowRedraw (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowRedraw, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowScreenShot
        /// Description: Saves current chart screen shot as a GIF file.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowscreenshot.html
        /// </summary>
        /// <param name="filename">[in] Screen shot file name. Screenshot is saved to \Files folder.</param>
        /// <param name="size_x">[in] Screen shot width in pixels.</param>
        /// <param name="size_y">[in] Screen shot height in pixels.</param>
        /// <param name="start_bar">[in] Index of the first visible bar in the screen shot. If 0 value is set, the current first visible bar will be shot. If no value or negative value has been set, the end-of-chart screen shot will be produced, indent being taken into consideration.</param>
        /// <param name="chart_scale">[in] Horizontal chart scale for screen shot. Can be in the range from 0 to 5. If no value or negative value has been set, the current chart scale will be used.</param>
        /// <param name="chart_mode">[in] Chart displaying mode. It can take the following values: CHART_BAR (0 is a sequence of bars), CHART_CANDLE (1 is a sequence of candlesticks), CHART_LINE (2 is a close prices line). If no value or negative value has been set, the chart will be shown in its current mode.</param>
        public bool WindowScreenShot (string filename, int size_x, int size_y, int start_bar, int chart_scale, int chart_mode)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(filename);
            parameters.Add(size_x);
            parameters.Add(size_y);
            parameters.Add(start_bar);
            parameters.Add(chart_scale);
            parameters.Add(chart_mode);
            
            CommandManager.getInstance().ExecCommand(Command.WindowScreenShot, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowTimeOnDropped
        /// Description: Returns the time of the chart point where Expert Advisor or script was dropped.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowtimeondropped.html
        /// </summary>
        public datetime WindowTimeOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowTimeOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowsTotal
        /// Description: Returns total number of indicator windows on the chart.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowstotal.html
        /// </summary>
        public int WindowsTotal (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowsTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowXOnDropped
        /// Description: Returns the value at X axis in pixels for the chart window client area point at which the Expert Advisor or script was dropped.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowxondropped.html
        /// </summary>
        public int WindowXOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowXOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: WindowYOnDropped
        /// Description: Returns the value at Y axis in pixels for the chart window client area point at which the Expert Advisor or script was dropped.
        /// URL: http://mm.l/mql4/docs.mql4.com/chart_operations/windowyondropped.html
        /// </summary>
        public int WindowYOnDropped (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.WindowYOnDropped, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderClose
        /// Description: Closes opened order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderclose.html
        /// </summary>
        /// <param name="ticket">[in] Unique number of the order ticket.</param>
        /// <param name="lots">[in] Number of lots.</param>
        /// <param name="price">[in] Closing price.</param>
        /// <param name="slippage">[in] Value of the maximum price slippage in points.</param>
        /// <param name="arrow_color">[in] Color of the closing arrow on the chart. If the parameter is missing or has CLR_NONE value closing arrow will not be drawn on the chart.</param>
        public bool OrderClose (int ticket, double lots, double price, int slippage, color arrow_color)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(ticket);
            parameters.Add(lots);
            parameters.Add(price);
            parameters.Add(slippage);
            parameters.Add(arrow_color);
            
            CommandManager.getInstance().ExecCommand(Command.OrderClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderCloseBy
        /// Description: Closes an opened order by another opposite opened order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordercloseby.html
        /// </summary>
        /// <param name="ticket">[in] Unique number of the order ticket.</param>
        /// <param name="opposite">[in] Unique number of the opposite order ticket.</param>
        /// <param name="arrow_color">[in] Color of the closing arrow on the chart. If the parameter is missing or has CLR_NONE value closing arrow will not be drawn on the chart.</param>
        public bool OrderCloseBy (int ticket, int opposite, color arrow_color)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(ticket);
            parameters.Add(opposite);
            parameters.Add(arrow_color);
            
            CommandManager.getInstance().ExecCommand(Command.OrderCloseBy, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderClosePrice
        /// Description: Returns close price of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordercloseprice.html
        /// </summary>
        public double OrderClosePrice (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderClosePrice, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderCloseTime
        /// Description: Returns close time of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderclosetime.html
        /// </summary>
        public datetime OrderCloseTime (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderCloseTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderComment
        /// Description: Returns comment of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordercomment.html
        /// </summary>
        public string OrderComment (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderComment, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderCommission
        /// Description: Returns calculated commission of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordercommission.html
        /// </summary>
        public double OrderCommission (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderCommission, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderDelete
        /// Description: Deletes previously opened pending order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderdelete.html
        /// </summary>
        /// <param name="ticket">[in] Unique number of the order ticket.</param>
        /// <param name="arrow_color">[in] Color of the arrow on the chart. If the parameter is missing or has CLR_NONE value arrow will not be drawn on the chart.</param>
        public bool OrderDelete (int ticket, color arrow_color)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(ticket);
            parameters.Add(arrow_color);
            
            CommandManager.getInstance().ExecCommand(Command.OrderDelete, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderExpiration
        /// Description: Returns expiration date of the selected pending order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderexpiration.html
        /// </summary>
        public datetime OrderExpiration (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderExpiration, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderLots
        /// Description: Returns amount of lots of the selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderlots.html
        /// </summary>
        public double OrderLots (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderLots, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderMagicNumber
        /// Description: Returns an identifying (magic) number of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordermagicnumber.html
        /// </summary>
        public int OrderMagicNumber (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderMagicNumber, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderModify
        /// Description: Modification of characteristics of the previously opened or pending orders.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordermodify.html
        /// </summary>
        /// <param name="ticket">[in] Unique number of the order ticket.</param>
        /// <param name="price">[in] New open price of the pending order.</param>
        /// <param name="stoploss">[in] New StopLoss level.</param>
        /// <param name="takeprofit">[in] New TakeProfit level.</param>
        /// <param name="expiration">[in] Pending order expiration time.</param>
        /// <param name="arrow_color">[in] Arrow color for StopLoss/TakeProfit modifications in the chart. If the parameter is missing or has CLR_NONE value, the arrows will not be shown in the chart.</param>
        public bool OrderModify (int ticket, double price, double stoploss, double takeprofit, datetime expiration, color arrow_color)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(ticket);
            parameters.Add(price);
            parameters.Add(stoploss);
            parameters.Add(takeprofit);
            parameters.Add(expiration);
            parameters.Add(arrow_color);
            
            CommandManager.getInstance().ExecCommand(Command.OrderModify, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderOpenPrice
        /// Description: Returns open price of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderopenprice.html
        /// </summary>
        public double OrderOpenPrice (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderOpenPrice, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderOpenTime
        /// Description: Returns open time of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderopentime.html
        /// </summary>
        public datetime OrderOpenTime (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderOpenTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderPrint
        /// Description: Prints information about the selected order in the log.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderprint.html
        /// </summary>
        public void OrderPrint (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderPrint, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderProfit
        /// Description: Returns profit of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderprofit.html
        /// </summary>
        public double OrderProfit (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderProfit, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderSelect
        /// Description: The function selects an order for further processing.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderselect.html
        /// </summary>
        /// <param name="index"></param>
        /// <param name="select">[in] Selecting flags. It can be any of the following values:</param>
        /// <param name="pool">SELECT_BY_POS - index in the order pool, SELECT_BY_TICKET - index is order ticket.</param>
        public bool OrderSelect (int index, int select, int pool)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(select);
            parameters.Add(pool);
            
            CommandManager.getInstance().ExecCommand(Command.OrderSelect, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderSend
        /// Description: The main function used to open market or place a pending order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordersend.html
        /// </summary>
        /// <param name="symbol">[in] Symbol for trading.</param>
        /// <param name="cmd">[in] Operation type. It can be any of the enumeration.</param>
        /// <param name="volume">[in] Number of lots.</param>
        /// <param name="price">[in] Order price.</param>
        /// <param name="slippage">[in] Maximum price slippage for buy or sell orders.</param>
        /// <param name="stoploss">[in] Stop loss level.</param>
        /// <param name="takeprofit">[in] Take profit level.</param>
        /// <param name="comment">[in] Order comment text. Last part of the comment may be changed by server.</param>
        /// <param name="magic">[in] Order magic number. May be used as user defined identifier.</param>
        /// <param name="expiration">[in] Order expiration time (for pending orders only).</param>
        /// <param name="arrow_color">[in] Color of the opening arrow on the chart. If parameter is missing or has CLR_NONE value opening arrow is not drawn on the chart.</param>
        public int OrderSend (string symbol, int cmd, double volume, double price, int slippage, double stoploss, double takeprofit, string comment, int magic, datetime expiration, color arrow_color)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(cmd);
            parameters.Add(volume);
            parameters.Add(price);
            parameters.Add(slippage);
            parameters.Add(stoploss);
            parameters.Add(takeprofit);
            parameters.Add(comment);
            parameters.Add(magic);
            parameters.Add(expiration);
            parameters.Add(arrow_color);
            
            CommandManager.getInstance().ExecCommand(Command.OrderSend, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrdersHistoryTotal
        /// Description: Returns the number of closed orders in the account history loaded into the terminal.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordershistorytotal.html
        /// </summary>
        public int OrdersHistoryTotal (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrdersHistoryTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderStopLoss
        /// Description: Returns stop loss value of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderstoploss.html
        /// </summary>
        public double OrderStopLoss (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderStopLoss, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrdersTotal
        /// Description: Returns the number of market and pending orders.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderstotal.html
        /// </summary>
        public int OrdersTotal (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrdersTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderSwap
        /// Description: Returns swap value of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderswap.html
        /// </summary>
        public double OrderSwap (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderSwap, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderSymbol
        /// Description: Returns symbol name of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordersymbol.html
        /// </summary>
        public string OrderSymbol (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderSymbol, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderTakeProfit
        /// Description: Returns take profit value of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordertakeprofit.html
        /// </summary>
        public double OrderTakeProfit (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderTakeProfit, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderTicket
        /// Description: Returns ticket number of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/orderticket.html
        /// </summary>
        public int OrderTicket (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderTicket, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: OrderType
        /// Description: Returns order operation type of the currently selected order.
        /// URL: http://mm.l/mql4/docs.mql4.com/trading/ordertype.html
        /// </summary>
        public int OrderType (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.OrderType, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalBaseGetDouble
        /// Description: Returns the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalbasegetdouble.html
        /// </summary>
        /// <param name="property_id">[in] Signal property identifier. The value can be one of the values of the enumeration.</param>
        public double SignalBaseGetDouble (ENUM_SIGNAL_BASE_DOUBLE property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.SignalBaseGetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalBaseGetInteger
        /// Description: Returns the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalbasegetinteger.html
        /// </summary>
        /// <param name="property_id">[in] Signal property identifier. The value can be one of the values of the enumeration.</param>
        public long SignalBaseGetInteger (ENUM_SIGNAL_BASE_INTEGER property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.SignalBaseGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalBaseGetString
        /// Description: Returns the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalbasegetstring.html
        /// </summary>
        /// <param name="property_id">[in] Signal property identifier. The value can be one of the values of the enumeration.</param>
        public string SignalBaseGetString (ENUM_SIGNAL_BASE_STRING property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.SignalBaseGetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalBaseSelect
        /// Description: Selects a signal from signals, available in terminal for further working with it.
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalbaseselect.html
        /// </summary>
        /// <param name="index">[in] Signal index in base of trading signals.</param>
        public bool SignalBaseSelect (int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.SignalBaseSelect, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalBaseTotal
        /// Description: Returns the total amount of signals, available in terminal.
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalbasetotal.html
        /// </summary>
        public int SignalBaseTotal (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.SignalBaseTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalInfoGetDouble
        /// Description: Returns the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalinfogetdouble.html
        /// </summary>
        /// <param name="property_id">[in] Signal copy settings property identifier. The value can be one of the values of the enumeration.</param>
        public double SignalInfoGetDouble (ENUM_SIGNAL_INFO_DOUBLE property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.SignalInfoGetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalInfoGetInteger
        /// Description: Returns the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalinfogetinteger.html
        /// </summary>
        /// <param name="property_id">[in] Signal copy settings property identifier. The value can be one of the values of the enumeration.</param>
        public long SignalInfoGetInteger (ENUM_SIGNAL_INFO_INTEGER property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.SignalInfoGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalInfoGetString
        /// Description: Returns the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalinfogetstring.html
        /// </summary>
        /// <param name="property_id">[in] Signal copy settings property identifier. The value can be one of the values of the enumeration.</param>
        public string SignalInfoGetString (ENUM_SIGNAL_INFO_STRING property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.SignalInfoGetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalInfoSetDouble
        /// Description: Sets the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalinfosetdouble.html
        /// </summary>
        /// <param name="property_id">[in] Signal copy settings property identifier. The value can be one of the values of the enumeration.</param>
        /// <param name="value">[in] The value of signal copy settings property.</param>
        public bool SignalInfoSetDouble (ENUM_SIGNAL_INFO_DOUBLE property_id, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.SignalInfoSetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalInfoSetInteger
        /// Description: Sets the value of
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalinfosetinteger.html
        /// </summary>
        /// <param name="property_id">[in] Signal copy settings property identifier. The value can be one of the values of the enumeration.</param>
        /// <param name="value">[in] The value of signal copy settings property.</param>
        public bool SignalInfoSetInteger (ENUM_SIGNAL_INFO_INTEGER property_id, long value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(property_id);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.SignalInfoSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalSubscribe
        /// Description: Subscribes to the trading signal.
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalsubscribe.html
        /// </summary>
        /// <param name="signal_id">[in] Signal identifier.</param>
        public bool SignalSubscribe (long signal_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(signal_id);
            
            CommandManager.getInstance().ExecCommand(Command.SignalSubscribe, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SignalUnsubscribe
        /// Description: Cancels subscription.
        /// URL: http://mm.l/mql4/docs.mql4.com/signals/signalunsubscribe.html
        /// </summary>
        public bool SignalUnsubscribe (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.SignalUnsubscribe, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableCheck
        /// Description: Checks the existence of a global variable with the specified name
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariablecheck.html
        /// </summary>
        /// <param name="name">[in] Global variable name.</param>
        public bool GlobalVariableCheck (string name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableCheck, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableTime
        /// Description: Returns the time when the global variable was last accessed.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariabletime.html
        /// </summary>
        /// <param name="name">[in] Name of the global variable.</param>
        public datetime GlobalVariableTime (string name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableDel
        /// Description: Deletes a global variable from the client terminal
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariabledel.html
        /// </summary>
        /// <param name="name">[in] Global variable name.</param>
        public bool GlobalVariableDel (string name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableDel, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableGet
        /// Description: Returns the value of an existing global variable of the client terminal. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariableget.html
        /// </summary>
        /// <param name="name">[in] Global variable name.</param>
        public double GlobalVariableGet (string name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableGet, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableGet
        /// Description: Returns the value of an existing global variable of the client terminal. There are 2 variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariableget.html
        /// </summary>
        /// <param name="name">[in] Global variable name.</param>
        /// <param name="double_var">[out] Target variable of the double type, which accepts the value stored in a the global variable of the client terminal.</param>
        public bool GlobalVariableGet (string name, double& double_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(double_var);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableGet, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableName
        /// Description: Returns the name of a global variable by its ordinal number.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariablename.html
        /// </summary>
        /// <param name="index">[in] Sequence number in the list of global variables. It should be greater than or equal to 0 and less than .</param>
        public string GlobalVariableName (int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableSet
        /// Description: Sets a new value for a global variable. If the variable does not exist, the system creates a new global variable.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariableset.html
        /// </summary>
        /// <param name="name">[in] Global variable name.</param>
        /// <param name="value">[in] The new numerical value.</param>
        public datetime GlobalVariableSet (string name, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableSet, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariablesFlush
        /// Description: Forcibly saves contents of all global variables to a disk.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariablesflush.html
        /// </summary>
        public void GlobalVariablesFlush (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariablesFlush, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableTemp
        /// Description: The function attempts to create a temporary global variable. If the variable doesn't exist, the system creates a new temporary global variable.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariabletemp.html
        /// </summary>
        /// <param name="name">[in] The name of a temporary global variable.</param>
        public bool GlobalVariableTemp (string name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableTemp, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariableSetOnCondition
        /// Description: Sets the new value of the existing global variable if the current value equals to the third parameter check_value. If there is no global variable, the function will generate an error ERR_GLOBALVARIABLE_NOT_FOUND (4501) and return false.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariablesetoncondition.html
        /// </summary>
        /// <param name="name">[in] The name of a global variable.</param>
        /// <param name="value">[in] New value.</param>
        /// <param name="check_value">[in] The value to check the current value of the global variable.</param>
        public bool GlobalVariableSetOnCondition (string name, double value, double check_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(value);
            parameters.Add(check_value);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariableSetOnCondition, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariablesDeleteAll
        /// Description: Deletes global variables of the client terminal.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariablesdeleteall.html
        /// </summary>
        /// <param name="prefix_name">[in] Name prefix global variables to remove. If you specify a prefix NULL or empty string, then all variables that meet the data criterion will be deleted.</param>
        /// <param name="limit_data">[in] Optional parameter. Date to select global variables by the time of their last modification. The function removes global variables, which were changed before this date. If the parameter is zero, then all variables that meet the first criterion (prefix) are deleted.</param>
        public int GlobalVariablesDeleteAll (string prefix_name, datetime limit_data)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(prefix_name);
            parameters.Add(limit_data);
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariablesDeleteAll, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: GlobalVariablesTotal
        /// Description: Returns the total number of global variables of the client terminal.
        /// URL: http://mm.l/mql4/docs.mql4.com/globals/globalvariablestotal.html
        /// </summary>
        public int GlobalVariablesTotal (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.GlobalVariablesTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileFindFirst
        /// Description: The function starts the search of files or
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filefindfirst.html
        /// </summary>
        /// <param name="file_filter">[in] Search filter. A subdirectory (or sequence of nested subdirectories) relative to the \Files directory, in which files should be searched for, can be specified in the filter.</param>
        /// <param name="returned_filename">[out] The returned parameter, where, in case of success, the name of the first found file or subdirectory is placed. Only the file name is returned (including the extension), the directories and subdirectories are not included no matter if they are specified or not in the search filter.</param>
        /// <param name="common_flag">[in] determining the location of the file. If common_flag = FILE_COMMON, then the file is located in a shared folder for all client terminals \Terminal\Common\Files. Otherwise, the file is located in a local folder.</param>
        public long FileFindFirst (const string file_filter, string& returned_filename, int common_flag)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_filter);
            parameters.Add(returned_filename);
            parameters.Add(common_flag);
            
            CommandManager.getInstance().ExecCommand(Command.FileFindFirst, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileFindNext
        /// Description: The function continues the search started by
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filefindnext.html
        /// </summary>
        /// <param name="search_handle">[in] Search handle, retrieved by .</param>
        /// <param name="returned_filename">[out] The name of the next file or subdirectory found. Only the file name is returned (including the extension), the directories and subdirectories are not included no matter if they are specified or not in the search filter.</param>
        public bool FileFindNext (long search_handle, string& returned_filename)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(search_handle);
            parameters.Add(returned_filename);
            
            CommandManager.getInstance().ExecCommand(Command.FileFindNext, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileFindClose
        /// Description: The function closes the search handle.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filefindclose.html
        /// </summary>
        /// <param name="search_handle">[in] Search handle, retrieved by .</param>
        public void FileFindClose (long search_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(search_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileFindClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileIsExist
        /// Description: Checks the existence of a file.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileisexist.html
        /// </summary>
        /// <param name="file_name">[in] The name of the file being checked</param>
        /// <param name="common_flag">[in] determining the location of the file. If common_flag = FILE_COMMON, then the file is located in a shared folder for all client terminals \Terminal\Common\Files. Otherwise, the file is located in a local folder.</param>
        public bool FileIsExist (const string file_name, int common_flag)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_name);
            parameters.Add(common_flag);
            
            CommandManager.getInstance().ExecCommand(Command.FileIsExist, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileOpen
        /// Description: The function opens the file with the specified name and flag.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileopen.html
        /// </summary>
        /// <param name="file_name">[in] The name of the file can contain subfolders. If the file is opened for writing, these subfolders will be created if there are no such ones.</param>
        /// <param name="open_flags">[in] determining the operation mode for the file. The flags are defined as follows:FILE_READ file is opened for readingFILE_WRITE file is opened for writingFILE_BIN binary read-write mode (no conversion from a string and to a string)FILE_CSV file of csv type (all recorded items are converted to the strings of unicode or ansi type, and are separated by a delimiter)FILE_TXT a simple text file (the same as csv, but the delimiter is not taken into account)FILE_ANSI lines of ANSI type (single-byte symbols) FILE_UNICODE lines of UNICODE type (double-byte characters)FILE_SHARE_READ shared reading from several programsFILE_SHARE_WRITE shared writing from several programsFILE_COMMON location of the file in a shared folder for all client terminals \Terminal\Common\Files</param>
        /// <param name="delimiter">[in] value to be used as a separator in txt or csv-file. If the csv-file delimiter is not specified, the default delimiter is ";". If the txt-file delimiter is not specified, then no separator is used. If the separator is clearly set to 0, then no separator is used.</param>
        /// <param name="codepage">[in] Optional parameter. The value of the code page. For the most-used provide appropriate constants.</param>
        public int FileOpen (string file_name, int open_flags, short delimiter, uint codepage)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_name);
            parameters.Add(open_flags);
            parameters.Add(delimiter);
            parameters.Add(codepage);
            
            CommandManager.getInstance().ExecCommand(Command.FileOpen, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileClose
        /// Description: Close the file previously opened by
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileclose.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by FileOpen().</param>
        public void FileClose (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileClose, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileCopy
        /// Description: The function copies the original file from a local or shared folder to another file.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filecopy.html
        /// </summary>
        /// <param name="src_file_name">[in] File name to copy.</param>
        /// <param name="common_flag">[in] determining the location of the file. If common_flag = FILE_COMMON, then the file is located in a shared folder for all client terminals \Terminal\Common\Files. Otherwise, the file is located in a local folder (for example, common_flag=0).</param>
        /// <param name="dst_file_name">[in] Result file name.</param>
        /// <param name="mode_flags">[in] . The parameter can contain only 2 flags: FILE_REWRITE and/or FILE_COMMON - other flags are ignored. If the file already exists, and the FILE_REWRITE flag hasn't been specified, then the file will not be rewritten, and the function will return false.</param>
        public bool FileCopy (const string src_file_name, int common_flag, const string dst_file_name, int mode_flags)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(src_file_name);
            parameters.Add(common_flag);
            parameters.Add(dst_file_name);
            parameters.Add(mode_flags);
            
            CommandManager.getInstance().ExecCommand(Command.FileCopy, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileDelete
        /// Description: Deletes the specified file in a local folder of the client terminal.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filedelete.html
        /// </summary>
        /// <param name="file_name">[in] File name.</param>
        /// <param name="common_flag">[in] determining the file location. If common_flag = FILE_COMMON, then the file is located in a shared folder for all client terminals \Terminal\Common\Files. Otherwise, the file is located in a local folder.</param>
        public bool FileDelete (const string file_name, int common_flag)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_name);
            parameters.Add(common_flag);
            
            CommandManager.getInstance().ExecCommand(Command.FileDelete, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileMove
        /// Description: Moves a file from a local or shared folder to another folder.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filemove.html
        /// </summary>
        /// <param name="src_file_name">[in] File name to move/rename.</param>
        /// <param name="common_flag">[in] determining the location of the file. If common_flag = FILE_COMMON, then the file is located in a shared folder for all client terminals \Terminal\Common\Files. Otherwise, the file is located in a local folder (common_flag=0).</param>
        /// <param name="dst_file_name">[in] File name after operation</param>
        /// <param name="mode_flags">[in] . The parameter can contain only 2 flags: FILE_REWRITE and/or FILE_COMMON - other flags are ignored. If the file already exists and the FILE_REWRITE flag isn't specified, the file will not be rewritten, and the function will return false.</param>
        public bool FileMove (const string src_file_name, int common_flag, const string dst_file_name, int mode_flags)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(src_file_name);
            parameters.Add(common_flag);
            parameters.Add(dst_file_name);
            parameters.Add(mode_flags);
            
            CommandManager.getInstance().ExecCommand(Command.FileMove, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileFlush
        /// Description: Writes to a disk all data remaining in the input/output file buffer.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileflush.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public void FileFlush (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileFlush, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileGetInteger
        /// Description: Gets an integer property of a file. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filegetinteger.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="property_id">[in] File property ID. The value can be one of the values of the enumeration. If the second variant of the function is used, you can receive only the values of the : FILE_EXISTS, FILE_CREATE_DATE, FILE_MODIFY_DATE, FILE_ACCESS_DATE and FILE_SIZE.</param>
        public long FileGetInteger (int file_handle, ENUM_FILE_PROPERTY_INTEGER property_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(property_id);
            
            CommandManager.getInstance().ExecCommand(Command.FileGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileGetInteger
        /// Description: Gets an integer property of a file. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filegetinteger.html
        /// </summary>
        /// <param name="file_name">[in] File name.</param>
        /// <param name="property_id">[in] File property ID. The value can be one of the values of the enumeration. If the second variant of the function is used, you can receive only the values of the : FILE_EXISTS, FILE_CREATE_DATE, FILE_MODIFY_DATE, FILE_ACCESS_DATE and FILE_SIZE.</param>
        /// <param name="common_folder">[in] Points to the file location. If the parameter is false, terminal data folder is viewed. Otherwise it is assumed that the file is in the shared folder of all terminals \Terminal\Common\Files ().</param>
        public long FileGetInteger (const string file_name, ENUM_FILE_PROPERTY_INTEGER property_id, bool common_folder)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_name);
            parameters.Add(property_id);
            parameters.Add(common_folder);
            
            CommandManager.getInstance().ExecCommand(Command.FileGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileIsEnding
        /// Description: Defines the end of a file in the process of reading.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileisending.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public bool FileIsEnding (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileIsEnding, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileIsLineEnding
        /// Description: Defines the line end in a text file in the process of reading.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileislineending.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public bool FileIsLineEnding (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileIsLineEnding, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadArray
        /// Description: Reads from a file of BIN type arrays of any type except string (may be an array of structures, not containing strings, and dynamic arrays
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadarray.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="array[]">[out] An array where the data will be loaded.</param>
        /// <param name="start">[in] Start position to write to the array.</param>
        /// <param name="count">[in] Number of elements to read. By default, reads the entire array (count=).</param>
        public uint FileReadArray (int file_handle, void& array[], int start, int count)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(array[]);
            parameters.Add(start);
            parameters.Add(count);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadBool
        /// Description: Reads from the file of CSV type string from the current position to a delimiter (or till the end of the text line) and converts the read string to a bool type value.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadbool.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public bool FileReadBool (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadBool, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadDatetime
        /// Description: Reads from the file of CSV type a string of one of the formats: "YYYY.MM.DD HH:MI:SS", "YYYY.MM.DD" or "HH:MI:SS" - and converts it into a value of datetime type.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereaddatetime.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public datetime FileReadDatetime (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadDatetime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadDouble
        /// Description: Reads a double-precision floating point number (double) from the current position of the binary file.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereaddouble.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="size">Number of bytes (up to 8 inclusive), that should be read. The corresponding constants are provided: DOUBLE_VALUE = 8, FLOAT_VALUE = 4, so the function can read the whole value of double or float type.</param>
        public double FileReadDouble (int file_handle, int size)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(size);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadFloat
        /// Description: Reads the single-precision floating point number (float) from the current position of the binary file.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadfloat.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public float FileReadFloat (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadFloat, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (float) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadInteger
        /// Description: The function reads int, short or char value from the current position of the file pointer depending on the length specified in bytes.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadinteger.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="size">[in] Number of bytes (up to 4 inclusive) that should be read. The corresponding constants are provided: CHAR_VALUE = 1, SHORT_VALUE = 2 and INT_VALUE (LONG_VALUE) = 4, so the function can read the whole value of char, short, int or long type.</param>
        public int FileReadInteger (int file_handle, int size)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(size);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadLong
        /// Description: The function reads an integer of long type (8 bytes) from the current position of the binary file.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadlong.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public long FileReadLong (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadLong, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadNumber
        /// Description: The function reads from the CSV file a string from the current position till a separator (or till the end of a text string) and converts the read string to a value of double type.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadnumber.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public double FileReadNumber (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadNumber, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadString
        /// Description: The function reads a string from the current position of a file pointer in a file.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadstring.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="length">[in] Number of characters to read.</param>
        public string FileReadString (int file_handle, int length)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(length);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileReadStruct
        /// Description: The function reads contents into a structure passed as a parameter from a binary-file, starting with the current position of the file pointer.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filereadstruct.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor of an open bin-file.</param>
        /// <param name="struct_object">[out] The object of this structure. The structure should not contain strings, or .</param>
        /// <param name="size">[in] Number of bytes that should be read. If size is not specified or the indicated value is greater than the size of the structure, the exact size of the specified structure is used.</param>
        public uint FileReadStruct (int file_handle, const void& struct_object, int size)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(struct_object);
            parameters.Add(size);
            
            CommandManager.getInstance().ExecCommand(Command.FileReadStruct, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileSeek
        /// Description: The function moves the position of the file pointer by a specified number of bytes relative to the specified position.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileseek.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="offset">[in] The shift in bytes (may take a negative value).</param>
        /// <param name="origin">[in] The starting point for the displacement. Can be one of values of .</param>
        public bool FileSeek (int file_handle, long offset, ENUM_FILE_POSITION origin)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(offset);
            parameters.Add(origin);
            
            CommandManager.getInstance().ExecCommand(Command.FileSeek, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileSize
        /// Description: The function returns the file size in bytes.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filesize.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public ulong FileSize (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileSize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (ulong) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileTell
        /// Description: The file returns the current position of the file pointer of an open file.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filetell.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public ulong FileTell (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileTell, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (ulong) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWrite
        /// Description: The function is intended for writing of data into a CSV file, delimiter being inserted automatically unless it is equal to 0. After writing into the file, the line end character "\r\n" will be added.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewrite.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        public uint FileWrite (int file_handle)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            
            CommandManager.getInstance().ExecCommand(Command.FileWrite, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWriteArray
        /// Description: The function writes arrays of any type except for string to a BIN file (can be an array of structures not containing strings or dynamic arrays).
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewritearray.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="array[]">[out] Array for recording.</param>
        /// <param name="start">[in] Initial index in the array (number of the first recorded element).</param>
        /// <param name="count">[in] Number of items to write ( means all items starting with the number start until the end of the array).</param>
        public uint FileWriteArray (int file_handle, const void& array[], int start, int count)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(array[]);
            parameters.Add(start);
            parameters.Add(count);
            
            CommandManager.getInstance().ExecCommand(Command.FileWriteArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWriteDouble
        /// Description: The function writes the value of a double parameter to a file, starting from the current position of the file pointer.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewritedouble.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="value">[in] The value of double type.</param>
        public uint FileWriteDouble (int file_handle, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.FileWriteDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWriteFloat
        /// Description: The function writes the value of the float parameter to a bin-file, starting from the current position of the file pointer.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewritefloat.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="value">[in] The value of float type.</param>
        public uint FileWriteFloat (int file_handle, float value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.FileWriteFloat, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWriteInteger
        /// Description: The function writes the value of the int parameter to a bin-file, starting from the current position of the file pointer.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewriteinteger.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="value">[in] Integer value.</param>
        /// <param name="size">[in] Number of bytes (up to 4 inclusive), that should be written. The corresponding constants are provided: CHAR_VALUE=1, SHORT_VALUE=2 and INT_VALUE=4, so the function can write the integer value of char, uchar, short, ushort, int, or uint type.</param>
        public uint FileWriteInteger (int file_handle, int value, int size)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(value);
            parameters.Add(size);
            
            CommandManager.getInstance().ExecCommand(Command.FileWriteInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWriteLong
        /// Description: The function writes the value of the long-type parameter to a bin-file, starting from the current position of the file pointer.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewritelong.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="value">[in] Value of type long.</param>
        public uint FileWriteLong (int file_handle, long value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.FileWriteLong, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWriteString
        /// Description: The function writes the value of a string-type parameter into a BIN, CSV or TXT file starting from the current position of the file pointer. When writing to a CSV or TXT file: if there is a symbol in the string '\n' (LF) without previous character '\r' (CR), then before '\n' the missing '\r' is added.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewritestring.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="text_string">[in] String.</param>
        /// <param name="length">[in] The number of characters that you want to write. This option is needed for writing a string into a BIN file. If the size is not specified, then the entire string without the trailer 0 is written. If you specify a size smaller than the length of the string, then a part of the string without the trailer 0 is written. If you specify a size greater than the length of the string, the string is filled by the appropriate number of zeros. For files of CSV and TXT type, this parameter is ignored and the string is written entirely.</param>
        public uint FileWriteString (int file_handle, const string text_string, int length)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(text_string);
            parameters.Add(length);
            
            CommandManager.getInstance().ExecCommand(Command.FileWriteString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileWriteStruct
        /// Description: The function writes into a bin-file contents of a structure passed as a parameter, starting from the current position of the file pointer.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/filewritestruct.html
        /// </summary>
        /// <param name="file_handle">[in] File descriptor returned by .</param>
        /// <param name="struct_object">[in] Reference to the object of this structure. The structure should not contain strings, or .</param>
        /// <param name="size">[in] Number of bytes that you want to record. If size is not specified or the specified number of bytes is greater than the size of the structure, the entire structure is written.</param>
        public uint FileWriteStruct (int file_handle, const void& struct_object, int size)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(file_handle);
            parameters.Add(struct_object);
            parameters.Add(size);
            
            CommandManager.getInstance().ExecCommand(Command.FileWriteStruct, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (uint) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FolderCreate
        /// Description: The function creates a folder in the Files directory (depending on the value of common_flag).
        /// URL: http://mm.l/mql4/docs.mql4.com/files/foldercreate.html
        /// </summary>
        /// <param name="folder_name">[in] The name of the directory you want to create. Contains the full path to the folder.</param>
        /// <param name="common_flag">[in] determining the location of the directory. If common_flag=FILE_COMMON, then the directory is in the shared folder for all client terminals \Terminal\Common\Files. Otherwise, the directory is in a local folder (MQL4\Files or MQL4\Tester\Files in case of testing).</param>
        public bool FolderCreate (string folder_name, int common_flag)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(folder_name);
            parameters.Add(common_flag);
            
            CommandManager.getInstance().ExecCommand(Command.FolderCreate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FolderDelete
        /// Description: The function removes the specified directory. If the folder is not empty, then it can't be removed.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/folderdelete.html
        /// </summary>
        /// <param name="folder_name">[in] The name of the directory you want to delete. Contains the full path to the folder.</param>
        /// <param name="common_flag">[in] determining the location of the directory. If common_flag=FILE_COMMON, then the directory is in the shared folder for all client terminals \Terminal\Common\Files. Otherwise, the directory is in a local folder (MQL4\Files or MQL4\Tester\Files in the case of testing).</param>
        public bool FolderDelete (string folder_name, int common_flag)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(folder_name);
            parameters.Add(common_flag);
            
            CommandManager.getInstance().ExecCommand(Command.FolderDelete, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FolderClean
        /// Description: The function deletes all files in a specified folder.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/folderclean.html
        /// </summary>
        /// <param name="folder_name">[in] The name of the directory where you want to delete all files. Contains the full path to the folder.</param>
        /// <param name="common_flag">[in] determining the location of the directory. If common_flag = FILE_COMMON, then the directory is in the shared folder for all client terminals \Terminal\Common\Files. Otherwise, the directory is in a local folder(MQL4\files or MQL4\tester\files in case of testing).</param>
        public bool FolderClean (string folder_name, int common_flag)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(folder_name);
            parameters.Add(common_flag);
            
            CommandManager.getInstance().ExecCommand(Command.FolderClean, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: FileOpenHistory
        /// Description: Opens file in the current history directory (terminal_directory\history\server_name) or in its subfolders.
        /// URL: http://mm.l/mql4/docs.mql4.com/files/fileopenhistory.html
        /// </summary>
        /// <param name="filename">[in] File name.</param>
        /// <param name="mode">[in] File open mode. Can be one or combination of values: FILE_BIN, FILE_CSV, FILE_READ, FILE_WRITE, FILE_SHARE_READ, FILE_SHARE_WRITE.</param>
        /// <param name="delimiter">[in] Delimiter for csv files. By default, the ';' symbol will be passed.</param>
        public int FileOpenHistory (int filename, int mode, int delimiter)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(filename);
            parameters.Add(mode);
            parameters.Add(delimiter);
            
            CommandManager.getInstance().ExecCommand(Command.FileOpenHistory, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: HideTestIndicators
        /// Description: The function sets a flag hiding indicators called by the Expert Advisor.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/hidetestindicators.html
        /// </summary>
        /// <param name="hide">[in] Hiding flag.</param>
        public void HideTestIndicators (bool hide)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(hide);
            
            CommandManager.getInstance().ExecCommand(Command.HideTestIndicators, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorSetDouble
        /// Description: The function sets the value of the corresponding indicator property. Indicator property must be of the double type. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorsetdouble.html
        /// </summary>
        /// <param name="prop_id">[in] Identifier of the indicator property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_value">[in] Value of property.</param>
        public bool IndicatorSetDouble (int prop_id, double prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(prop_id);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorSetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorSetDouble
        /// Description: The function sets the value of the corresponding indicator property. Indicator property must be of the double type. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorsetdouble.html
        /// </summary>
        /// <param name="prop_id">[in] Identifier of the indicator property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. Only level properties require a modifier. Numbering of levels starts from 0. It means that in order to set property for the second level you need to specify 1 (1 less than when using ).</param>
        /// <param name="prop_value">[in] Value of property.</param>
        public bool IndicatorSetDouble (int prop_id, int prop_modifier, double prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorSetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorSetInteger
        /// Description: The function sets the value of the corresponding indicator property. Indicator property must be of the int or color type. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorsetinteger.html
        /// </summary>
        /// <param name="prop_id">[in] Identifier of the indicator property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_value">[in] Value of property.</param>
        public bool IndicatorSetInteger (int prop_id, int prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(prop_id);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorSetInteger
        /// Description: The function sets the value of the corresponding indicator property. Indicator property must be of the int or color type. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorsetinteger.html
        /// </summary>
        /// <param name="prop_id">[in] Identifier of the indicator property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. Only level properties require a modifier.</param>
        /// <param name="prop_value">[in] Value of property.</param>
        public bool IndicatorSetInteger (int prop_id, int prop_modifier, int prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorSetString
        /// Description: The function sets the value of the corresponding indicator property. Indicator property must be of the string type. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorsetstring.html
        /// </summary>
        /// <param name="prop_id">[in] Identifier of the indicator property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_value">[in] Value of property.</param>
        public bool IndicatorSetString (int prop_id, string prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(prop_id);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorSetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorSetString
        /// Description: The function sets the value of the corresponding indicator property. Indicator property must be of the string type. There are two variants of the function.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorsetstring.html
        /// </summary>
        /// <param name="prop_id">[in] Identifier of the indicator property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. Only level properties require a modifier.</param>
        /// <param name="prop_value">[in] Value of property.</param>
        public bool IndicatorSetString (int prop_id, int prop_modifier, string prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorSetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexBuffer
        /// Description: The function binds a specified indicator buffer with one-dimensional dynamic array of the
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexbuffer.html
        /// </summary>
        /// <param name="index">[in] Number of the indicator buffer. The numbering starts with 0. The number must be less than the value declared in .</param>
        /// <param name="buffer[]">[in] An array declared in the custom indicator program.</param>
        /// <param name="data_type"></param>
        public bool SetIndexBuffer (int index, double buffer[], ENUM_INDEXBUFFER_TYPE data_type)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(buffer[]);
            parameters.Add(data_type);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexBuffer, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexBuffer
        /// Description: The function binds a specified indicator buffer with one-dimensional dynamic array of the
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexbuffer.html
        /// </summary>
        /// <param name="index">[in] Number of the indicator buffer. The numbering starts with 0. The number must be less than the value declared in .</param>
        /// <param name="buffer[]">[in] An array declared in the custom indicator program.</param>
        public bool SetIndexBuffer (int index, double buffer[])
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(buffer[]);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexBuffer, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorBuffers
        /// Description: Allocates memory for buffers used for custom indicator calculations.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorbuffers.html
        /// </summary>
        /// <param name="count">[in] Amount of buffers to be allocated. Should be within the range between indicator_buffers and 512 buffers.</param>
        public bool IndicatorBuffers (int count)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(count);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorBuffers, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorCounted
        /// Description: The function returns the amount of bars not changed after the indicator had been launched last.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorcounted.html
        /// </summary>
        public int IndicatorCounted (
        {
            List<Object> parameters = new List<Object>();
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorCounted, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorDigits
        /// Description: Sets precision format (the count of digits after decimal point) to visualize indicator values.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatordigits.html
        /// </summary>
        /// <param name="digits">[in] Precision format, the count of digits after decimal point.</param>
        public void IndicatorDigits (int digits)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(digits);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorDigits, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: IndicatorShortName
        /// Description: Sets the "short" name of a custom indicator to be shown in the DataWindow and in the chart subwindow.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/indicatorshortname.html
        /// </summary>
        /// <param name="name">[in] New short name.</param>
        public void IndicatorShortName (string name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            
            CommandManager.getInstance().ExecCommand(Command.IndicatorShortName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexArrow
        /// Description: Sets an arrow symbol for indicators line of the DRAW_ARROW type.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexarrow.html
        /// </summary>
        /// <param name="index">[in] Line index. Must lie between 0 and 7.</param>
        /// <param name="code">[in] Symbol code from or predefined .</param>
        public void SetIndexArrow (int index, int code)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(code);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexArrow, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexDrawBegin
        /// Description: Sets the bar number (from the data beginning) from which the drawing of the given indicator line must start.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexdrawbegin.html
        /// </summary>
        /// <param name="index">[in] Line index. Must lie between 0 and 7.</param>
        /// <param name="begin">[in] First drawing bar position number.</param>
        public void SetIndexDrawBegin (int index, int begin)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(begin);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexDrawBegin, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexEmptyValue
        /// Description: Sets drawing line empty value.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexemptyvalue.html
        /// </summary>
        /// <param name="index">[in] Line index. Must lie between 0 and 7.</param>
        /// <param name="value">[in] New "empty" value.</param>
        public void SetIndexEmptyValue (int index, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexEmptyValue, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexLabel
        /// Description: Sets drawing line description for showing in the DataWindow and in the tooltip.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexlabel.html
        /// </summary>
        /// <param name="index">[in] Line index. Must lie between 0 and 7.</param>
        /// <param name="text">[in] Label text. NULL means that index value is not shown in the DataWindow.</param>
        public void SetIndexLabel (int index, string text)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(text);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexLabel, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexShift
        /// Description: Sets offset for the drawing line.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexshift.html
        /// </summary>
        /// <param name="index">[in] Line index. Must lie between 0 and 7.</param>
        /// <param name="shift">[in] Shift value in bars.</param>
        public void SetIndexShift (int index, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexShift, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetIndexStyle
        /// Description: Sets the new type, style, width and color for a given indicator line.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setindexstyle.html
        /// </summary>
        /// <param name="index">[in] Line index. Must lie between 0 and 7.</param>
        /// <param name="type">[in] Shape style. Can be one of listed.</param>
        /// <param name="style">[in] Drawing style. It is used for one-pixel thick lines. It can be one of the listed. EMPTY value means that the style will not be changed.</param>
        /// <param name="width">[in] Line width. Valid values are: 1,2,3,4,5. EMPTY value means that width will not be changed.</param>
        /// <param name="clr">[in] Line color. Absence of this parameter means that the color will not be changed.</param>
        public void SetIndexStyle (int index, int type, int style, int width, color clr)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(index);
            parameters.Add(type);
            parameters.Add(style);
            parameters.Add(width);
            parameters.Add(clr);
            
            CommandManager.getInstance().ExecCommand(Command.SetIndexStyle, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetLevelStyle
        /// Description: The function sets a new style, width and color of horizontal levels of indicator to be output in a separate window.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setlevelstyle.html
        /// </summary>
        /// <param name="draw_style">[in] Drawing style. Can be one of the listed. EMPTY value means that the style will not be changed.</param>
        /// <param name="line_width">[in] Line width. Valid values are 1,2,3,4,5. EMPTY value indicates that the width will not be changed.</param>
        /// <param name="clr">[in] Line color. Empty value CLR_NONE means that the color will not be changed.</param>
        public void SetLevelStyle (int draw_style, int line_width, color clr)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(draw_style);
            parameters.Add(line_width);
            parameters.Add(clr);
            
            CommandManager.getInstance().ExecCommand(Command.SetLevelStyle, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: SetLevelValue
        /// Description: The function sets a value for a given horizontal level of the indicator to be output in a separate window.
        /// URL: http://mm.l/mql4/docs.mql4.com/customind/setlevelvalue.html
        /// </summary>
        /// <param name="level">[in] Level index (0-31).</param>
        /// <param name="value">[in] Value for the given indicator level.</param>
        public void SetLevelValue (int level, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(level);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.SetLevelValue, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (void) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectCreate
        /// Description: The function creates an object with the specified name, type, and the initial coordinates in the specified chart subwindow of the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectcreate.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier.</param>
        /// <param name="object_name">[in] Name of the object. The name must be unique within a chart, including its subwindows.</param>
        /// <param name="object_type">[in] Object type. The value can be one of the values of the enumeration.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. 0 means the main chart window. The specified subwindow must exist (window index must be greater or equal to 0 and less than ), otherwise the function returns false.</param>
        /// <param name="time1">[in] The time coordinate of the first anchor point.</param>
        /// <param name="price1">[in] The price coordinate of the first anchor point.</param>
        /// <param name="timeN">[in] The time coordinate of the N-th anchor point.</param>
        /// <param name="priceN">[in] The price coordinate of the N-th anchor point.</param>
        public bool ObjectCreate (long chart_id, string object_name, ENUM_OBJECT object_type, int sub_window, datetime time1, double price1, datetime timeN, double priceN)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(object_type);
            parameters.Add(sub_window);
            parameters.Add(time1);
            parameters.Add(price1);
            parameters.Add(timeN);
            parameters.Add(priceN);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectCreate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectCreate
        /// Description: The function creates an object with the specified name, type, and the initial coordinates in the specified chart subwindow of the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectcreate.html
        /// </summary>
        /// <param name="object_name">[in] Name of the object. The name must be unique within a chart, including its subwindows.</param>
        /// <param name="object_type">[in] Object type. The value can be one of the values of the enumeration.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. 0 means the main chart window. The specified subwindow must exist (window index must be greater or equal to 0 and less than ), otherwise the function returns false.</param>
        /// <param name="time1">[in] The time coordinate of the first anchor point.</param>
        /// <param name="price1">[in] The price coordinate of the first anchor point.</param>
        /// <param name="time2">[in] The time coordinate of the second anchor point.</param>
        /// <param name="price2">[in] The price coordinate of the second anchor point.</param>
        /// <param name="time3">[in] The time coordinate of the third anchor point.</param>
        /// <param name="price3">[in] The price coordinate of the third anchor point.</param>
        public bool ObjectCreate (string object_name, ENUM_OBJECT object_type, int sub_window, datetime time1, double price1, datetime time2, double price2, datetime time3, double price3)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(object_type);
            parameters.Add(sub_window);
            parameters.Add(time1);
            parameters.Add(price1);
            parameters.Add(time2);
            parameters.Add(price2);
            parameters.Add(time3);
            parameters.Add(price3);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectCreate, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectName
        /// Description: The function returns the name of the corresponding object by its index in the objects list.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectname.html
        /// </summary>
        /// <param name="object_index">[in] Object index. This value must be greater or equal to 0 and less than .</param>
        public string ObjectName (int object_index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_index);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectName, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectDelete
        /// Description: The function removes the object with the specified name at the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectdelete.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier.</param>
        /// <param name="object_name">[in] Name of object to be deleted.</param>
        public bool ObjectDelete (long chart_id, string object_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectDelete, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectDelete
        /// Description: The function removes the object with the specified name at the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectdelete.html
        /// </summary>
        /// <param name="object_name">[in] Name of object to be deleted.</param>
        public bool ObjectDelete (string object_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectDelete, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectsDeleteAll
        /// Description: Removes all objects from the specified chart, specified chart subwindow, of the specified type.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsdeleteall.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier.</param>
        /// <param name="sub_window">[in] Number of the chart window. Must be greater or equal to -1 (-1 mean all subwindows, 0 means the main chart window) and less than .</param>
        /// <param name="object_type">[in] Type of the object. The value can be one of the values of the enumeration. EMPTY (-1) means all types.</param>
        public int ObjectsDeleteAll (long chart_id, int sub_window, int object_type)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(sub_window);
            parameters.Add(object_type);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectsDeleteAll, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectsDeleteAll
        /// Description: Removes all objects from the specified chart, specified chart subwindow, of the specified type.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsdeleteall.html
        /// </summary>
        /// <param name="sub_window">[in] Number of the chart window. Must be greater or equal to -1 (-1 mean all subwindows, 0 means the main chart window) and less than .</param>
        /// <param name="object_type">[in] Type of the object. The value can be one of the values of the enumeration. EMPTY (-1) means all types.</param>
        public int ObjectsDeleteAll (int sub_window, int object_type)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(sub_window);
            parameters.Add(object_type);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectsDeleteAll, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectsDeleteAll
        /// Description: Removes all objects from the specified chart, specified chart subwindow, of the specified type.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsdeleteall.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier.</param>
        /// <param name="prefix">[in] Prefix in object names. All objects whose names start with this set of characters will be removed from chart. You can specify prefix as 'name' or 'name*' both variants will work the same. If an empty string is specified as the prefix, objects with all possible names will be removed.</param>
        /// <param name="sub_window">[in] Number of the chart window. Must be greater or equal to -1 (-1 mean all subwindows, 0 means the main chart window) and less than .</param>
        /// <param name="object_type">[in] Type of the object. The value can be one of the values of the enumeration. EMPTY (-1) means all types.</param>
        public int ObjectsDeleteAll (long chart_id, const string prefix, int sub_window, int object_type)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(prefix);
            parameters.Add(sub_window);
            parameters.Add(object_type);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectsDeleteAll, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectFind
        /// Description: The function searches for an object having the specified name. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectfind.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier.</param>
        /// <param name="object_name">[in] The name of the object to find.</param>
        public int ObjectFind (long chart_id, string object_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectFind, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectFind
        /// Description: The function searches for an object having the specified name. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectfind.html
        /// </summary>
        /// <param name="object_name">[in] The name of the object to find.</param>
        public int ObjectFind (string object_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectFind, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetTimeByValue
        /// Description: The function returns the time value for the specified price value of the specified object.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgettimebyvalue.html
        /// </summary>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="value">[in] Price value.</param>
        /// <param name="line_id">[in] Line identifier.</param>
        public datetime ObjectGetTimeByValue (string object_name, double value, int line_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(value);
            parameters.Add(line_id);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetTimeByValue, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (datetime) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetValueByTime
        /// Description: The function returns the price value for the specified time value of the specified object.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetvaluebytime.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="time">[in] Time value.</param>
        /// <param name="line_id">[in] Line identifier.</param>
        public double ObjectGetValueByTime (long chart_id, string object_name, datetime time, int line_id)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(time);
            parameters.Add(line_id);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetValueByTime, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectMove
        /// Description: The function changes coordinates of the specified anchor point of the object at the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectmove.html
        /// </summary>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="point_index">[in] Index of the anchor point. The number of anchor points depends on the .</param>
        /// <param name="time">[in] Time coordinate of the selected anchor point.</param>
        /// <param name="price">[in] Price coordinate of the selected anchor point.</param>
        public bool ObjectMove (string object_name, int point_index, datetime time, double price)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(point_index);
            parameters.Add(time);
            parameters.Add(price);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectMove, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectMove
        /// Description: The function changes coordinates of the specified anchor point of the object at the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectmove.html
        /// </summary>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="point_index">[in] Index of the anchor point. The number of anchor points depends on the .</param>
        /// <param name="time">[in] Time coordinate of the selected anchor point.</param>
        /// <param name="price">[in] Price coordinate of the selected anchor point.</param>
        public bool ObjectMove (string object_name, int point_index, datetime time, double price)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(point_index);
            parameters.Add(time);
            parameters.Add(price);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectMove, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectsTotal
        /// Description: The function returns the number of objects of the specified type in the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectstotal.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier.</param>
        /// <param name="sub_window">[in] Number of the chart subwindow. 0 means the main chart window, -1 means all the subwindows of the chart, including the main window.</param>
        /// <param name="type">[in] Type of the object. The value can be one of the values of the enumeration. EMPTY(-1) means all types.</param>
        public int ObjectsTotal (long chart_id, int sub_window, int type)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(sub_window);
            parameters.Add(type);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectsTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectsTotal
        /// Description: The function returns the number of objects of the specified type in the specified chart. There are two variants of the function:
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectstotal.html
        /// </summary>
        /// <param name="type">[in] Type of the object. The value can be one of the values of the enumeration. EMPTY(-1) means all types.</param>
        public int ObjectsTotal (int type)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(type);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectsTotal, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetDouble
        /// Description: The function returns the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetdouble.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. For the first variant, the default modifier value is equal to 0. Most properties do not require a modifier. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        public double ObjectGetDouble (long chart_id, string object_name, int prop_id, int prop_modifier)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetDouble
        /// Description: The function returns the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetdouble.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. For the first variant, the default modifier value is equal to 0. Most properties do not require a modifier. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        /// <param name="double_var">[out] Variable of the double type that received the value of the requested property.</param>
        public bool ObjectGetDouble (long chart_id, string object_name, int prop_id, int prop_modifier, double& double_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(double_var);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetInteger
        /// Description: The function returns the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. For the first variant, the default modifier value is equal to 0. Most properties do not require a modifier. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        public long ObjectGetInteger (long chart_id, string object_name, int prop_id, int prop_modifier)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (long) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetInteger
        /// Description: The function returns the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. For the first variant, the default modifier value is equal to 0. Most properties do not require a modifier. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        /// <param name="long_var">[out] Variable of the long type that receives the value of the requested property.</param>
        public bool ObjectGetInteger (long chart_id, string object_name, int prop_id, int prop_modifier, long& long_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(long_var);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetString
        /// Description: The function returns the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetstring.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. For the first variant, the default modifier value is equal to 0. Most properties do not require a modifier. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        public string ObjectGetString (long chart_id, string object_name, int prop_id, int prop_modifier)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetString
        /// Description: The function returns the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetstring.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. For the first variant, the default modifier value is equal to 0. Most properties do not require a modifier. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        /// <param name="string_var">[out] Variable of the string type that receives the value of the requested properties.</param>
        public bool ObjectGetString (long chart_id, string object_name, int prop_id, int prop_modifier, string& string_var)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(string_var);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetDouble
        /// Description: The function sets the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsetdouble.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_value">[in] The value of the property.</param>
        public bool ObjectSetDouble (long chart_id, string object_name, int prop_id, double prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetDouble
        /// Description: The function sets the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsetdouble.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        /// <param name="prop_value">[in] The value of the property.</param>
        public bool ObjectSetDouble (long chart_id, string object_name, int prop_id, int prop_modifier, double prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetDouble, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetInteger
        /// Description: The function sets the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_value">[in] The value of the property.</param>
        public bool ObjectSetInteger (long chart_id, string object_name, int prop_id, long prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetInteger
        /// Description: The function sets the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsetinteger.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        /// <param name="prop_value">[in] The value of the property.</param>
        public bool ObjectSetInteger (long chart_id, string object_name, int prop_id, int prop_modifier, long prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetInteger, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetString
        /// Description: The function sets the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsetstring.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_value">[in] The value of the property.</param>
        public bool ObjectSetString (long chart_id, string object_name, int prop_id, string prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetString
        /// Description: The function sets the value of the corresponding object property. The object property must be of the
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsetstring.html
        /// </summary>
        /// <param name="chart_id">[in] Chart identifier. 0 means the current chart.</param>
        /// <param name="object_name">[in] Name of the object.</param>
        /// <param name="prop_id">[in] ID of the object property. The value can be one of the values of the enumeration.</param>
        /// <param name="prop_modifier">[in] Modifier of the specified property. It denotes the number of the level in and in the graphical object Andrew's pitchfork. The numeration of levels starts from zero.</param>
        /// <param name="prop_value">[in] The value of the property.</param>
        public bool ObjectSetString (long chart_id, string object_name, int prop_id, int prop_modifier, string prop_value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(chart_id);
            parameters.Add(object_name);
            parameters.Add(prop_id);
            parameters.Add(prop_modifier);
            parameters.Add(prop_value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetString, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TextSetFont
        /// Description: The function sets the font for displaying the text using drawing methods and returns the result of that operation. Arial font with the size -120 (12 pt) is used by default.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/textsetfont.html
        /// </summary>
        /// <param name="name">[in] Font name in the system or the name of the resource containing the font or the path to font file on the disk.</param>
        /// <param name="size">[in] The font size that can be set using positive and negative values. In case of positive values, the size of a displayed text does not depend on the operating system's font size settings. In case of negative values, the value is set in tenths of a point and the text size depends on the operating system settings ("standard scale" or "large scale"). See the Note below for more information about the differences between the modes.</param>
        /// <param name="flags">[in] Combination of describing font style.</param>
        /// <param name="orientation">[in] Text's horizontal inclination to X axis, the unit of measurement is 0.1 degrees. It means that orientation=450 stands for inclination equal to 45 degrees.</param>
        public bool TextSetFont (const string name, int size, uint flags, int orientation)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(name);
            parameters.Add(size);
            parameters.Add(flags);
            parameters.Add(orientation);
            
            CommandManager.getInstance().ExecCommand(Command.TextSetFont, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TextOut
        /// Description: The function displays a text in a custom array (buffer) and returns the result of that operation. The array is designed to create the graphical
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/textout.html
        /// </summary>
        /// <param name="text">[in] Displayed text that will be written to the buffer. Only one-lined text is displayed.</param>
        /// <param name="x">[in] X coordinate of the anchor point of the displayed text.</param>
        /// <param name="y">[in] Y coordinate of the anchor point of the displayed text.</param>
        /// <param name="anchor">[in] The value out of the 9 pre-defined methods of the displayed text's anchor point location. The value is set by a combination of two flags flags of horizontal and vertical text align. Flag names are listed in the Note below.</param>
        /// <param name="&data[]"></param>
        /// <param name="width">[in] Buffer width in pixels.</param>
        /// <param name="height">[in] Buffer height in pixels.</param>
        /// <param name="color">[in] Text color.</param>
        /// <param name="color_format">[in] Color format is set by enumeration value.</param>
        public bool TextOut (const string text, int x, int y, uint anchor, uint &data[], uint width, uint height, uint color, ENUM_COLOR_FORMAT color_format)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text);
            parameters.Add(x);
            parameters.Add(y);
            parameters.Add(anchor);
            parameters.Add(&data[]);
            parameters.Add(width);
            parameters.Add(height);
            parameters.Add(color);
            parameters.Add(color_format);
            
            CommandManager.getInstance().ExecCommand(Command.TextOut, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: TextGetSize
        /// Description: The function returns the line width and height at the current
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/textgetsize.html
        /// </summary>
        /// <param name="text">[in] String, for which length and width should be obtained.</param>
        /// <param name="width">[out] Input parameter for receiving width.</param>
        /// <param name="height">[out] Input parameter for receiving height.</param>
        public bool TextGetSize (const string text, uint& width, uint& height)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(text);
            parameters.Add(width);
            parameters.Add(height);
            
            CommandManager.getInstance().ExecCommand(Command.TextGetSize, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectDescription
        /// Description: Returns the object description.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectdescription.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        public string ObjectDescription (string object_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectDescription, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGet
        /// Description: Returns the value of the specified object property.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectget.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        /// <param name="index">[in] Object property index. It can be any of the enumeration values.</param>
        public double ObjectGet (string object_name, int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGet, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetFiboDescription
        /// Description: Returns the level description of a Fibonacci object.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetfibodescription.html
        /// </summary>
        /// <param name="object_name">[in] Fibonacci object name.</param>
        /// <param name="index">[in] Index of the Fibonacci level (0-31).</param>
        public string ObjectGetFiboDescription (string object_name, int index)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(index);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetFiboDescription, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (string) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetShiftByValue
        /// Description: The function calculates and returns bar index (shift related to the current bar) for the given price.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetshiftbyvalue.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        /// <param name="value">[in] Price value.</param>
        public int ObjectGetShiftByValue (string object_name, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetShiftByValue, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectGetValueByShift
        /// Description: The function calculates and returns the price value for the specified bar (shift related to the current bar).
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectgetvaluebyshift.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        /// <param name="shift">[in] Bar index.</param>
        public double ObjectGetValueByShift (string object_name, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectGetValueByShift, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSet
        /// Description: Changes the value of the specified object property.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectset.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        /// <param name="index">[in] Object property index. It can be any of enumeration values.</param>
        /// <param name="value">[in] New value of the given property.</param>
        public bool ObjectSet (string object_name, int index, double value)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(index);
            parameters.Add(value);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSet, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetFiboDescription
        /// Description: The function sets a new description to a level of a Fibonacci object.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsetfibodescription.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        /// <param name="index">[in] Index of the Fibonacci level (0-31).</param>
        /// <param name="text">[in] New description of the level.</param>
        public bool ObjectSetFiboDescription (string object_name, int index, string text)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(index);
            parameters.Add(text);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetFiboDescription, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectSetText
        /// Description: The function c
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objectsettext.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        /// <param name="text">[in] A text describing the object.</param>
        /// <param name="font_size">[in] Font size in points.</param>
        /// <param name="font_name">[in] Font name.</param>
        /// <param name="text_color">[in] Font color.</param>
        public bool ObjectSetText (string object_name, string text, int font_size, string font_name, color text_color)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            parameters.Add(text);
            parameters.Add(font_size);
            parameters.Add(font_name);
            parameters.Add(text_color);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectSetText, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (bool) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: ObjectType
        /// Description: The function returns the object type value.
        /// URL: http://mm.l/mql4/docs.mql4.com/objects/objecttype.html
        /// </summary>
        /// <param name="object_name">[in] Object name.</param>
        public int ObjectType (string object_name)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(object_name);
            
            CommandManager.getInstance().ExecCommand(Command.ObjectType, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (int) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iAC
        /// Description: Calculates the Bill Williams' Accelerator/Decelerator oscillator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iac.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iAC (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iAC, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iAD
        /// Description: Calculates the Accumulation/Distribution indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iad.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iAD (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iAD, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iADX
        /// Description: Calculates the Average Directional Movement Index indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iadx.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of the enumeration value. (0 - MODE_MAIN, 1 - MODE_PLUSDI, 2 - MODE_MINUSDI).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iADX (string symbol, int timeframe, int period, int applied_price, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(applied_price);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iADX, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iAlligator
        /// Description: Calculates the Alligator indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ialligator.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="jaw_period">[in] Blue line averaging period (Alligator's Jaw).</param>
        /// <param name="jaw_shift">[in] Blue line shift relative to the chart.</param>
        /// <param name="teeth_period">[in] Red line averaging period (Alligator's Teeth).</param>
        /// <param name="teeth_shift">[in] Red line shift relative to the chart.</param>
        /// <param name="lips_period">[in] Green line averaging period (Alligator's Lips).</param>
        /// <param name="lips_shift">[in] Green line shift relative to the chart.</param>
        /// <param name="ma_method">[in] MA method. It can be any of Moving Average methods. It can be any of enumeration values.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="mode">[in] Data source, identifier of the . It can be any of the following values:</param>
        /// <param name="shift">MODE_GATORJAW - Gator Jaw (blue) balance line,MODE_GATORTEETH - Gator Teeth (red) balance line,MODE_GATORLIPS - Gator Lips (green) balance line.</param>
        public double iAlligator (string symbol, int timeframe, int jaw_period, int jaw_shift, int teeth_period, int teeth_shift, int lips_period, int lips_shift, int ma_method, int applied_price, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(jaw_period);
            parameters.Add(jaw_shift);
            parameters.Add(teeth_period);
            parameters.Add(teeth_shift);
            parameters.Add(lips_period);
            parameters.Add(lips_shift);
            parameters.Add(ma_method);
            parameters.Add(applied_price);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iAlligator, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iAO
        /// Description: Calculates the Awesome oscillator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iao.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iAO (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iAO, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iATR
        /// Description: Calculates the Average True Range indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iatr.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iATR (string symbol, int timeframe, int period, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iATR, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iBearsPower
        /// Description: Calculates the Bears Power indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ibearspower.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iBearsPower (string symbol, int timeframe, int period, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iBearsPower, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iBands
        /// Description: Calculates the Bollinger Bands indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ibands.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period to calculate the main line.</param>
        /// <param name="deviation">[in] Number of standard deviations from the main line.</param>
        /// <param name="bands_shift">[in] The indicator shift relative to the chart.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of the enumeration value (0 - MODE_MAIN, 1 - MODE_UPPER, 2 - MODE_LOWER).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iBands (string symbol, int timeframe, int period, double deviation, int bands_shift, int applied_price, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(deviation);
            parameters.Add(bands_shift);
            parameters.Add(applied_price);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iBands, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iBandsOnArray
        /// Description: Calculates the Bollinger Bands indicator on data, stored in array, and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ibandsonarray.html
        /// </summary>
        /// <param name="array[]">[in] Array with data.</param>
        /// <param name="total">[in] The number of items to be counted. 0 means the whole array.</param>
        /// <param name="period">[in] Averaging period to calculate the main line.</param>
        /// <param name="deviation">[in] Number of standard deviations from the main line.</param>
        /// <param name="bands_shift">[in] The indicator shift relative to the chart.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of the enumeration value (0 - MODE_MAIN, 1 - MODE_UPPER, 2 - MODE_LOWER).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iBandsOnArray (double array[], int total, int period, double deviation, int bands_shift, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(total);
            parameters.Add(period);
            parameters.Add(deviation);
            parameters.Add(bands_shift);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iBandsOnArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iBullsPower
        /// Description: Calculates the Bulls Power indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ibullspower.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iBullsPower (string symbol, int timeframe, int period, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iBullsPower, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iCCI
        /// Description: Calculates the Commodity Channel Index indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/icci.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iCCI (string symbol, int timeframe, int period, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iCCI, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iCCIOnArray
        /// Description: Calculates the Commodity Channel Index indicator on data, stored in array, and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iccionarray.html
        /// </summary>
        /// <param name="array[]">[in] Array with data.</param>
        /// <param name="total">[in] The number of items to be counted. 0 means the whole array.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iCCIOnArray (double array[], int total, int period, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(total);
            parameters.Add(period);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iCCIOnArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iCustom
        /// Description: Calculates the specified custom indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/icustom.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="name">[in] Custom indicator compiled program name, relative to the root indicators directory (MQL4/Indicators/). If the indicator is located in subdirectory, for example, in MQL4/Indicators/Examples, its name must be specified as "Examples\\indicator_name" (double backslash "\\"must be specified as separator instead of a single one).</param>
        /// <param name="int"></param>
        /// <param name="int"></param>
        public double iCustom (string symbol, int timeframe, string name, custom indicator input parameters (if necessary) int, line index int)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(name);
            parameters.Add(int);
            parameters.Add(int);
            
            CommandManager.getInstance().ExecCommand(Command.iCustom, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iDeMarker
        /// Description: Calculates the DeMarker indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/idemarker.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iDeMarker (string symbol, int timeframe, int period, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iDeMarker, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iEnvelopes
        /// Description: Calculates the Envelopes indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ienvelopes.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="ma_period">[in] Averaging period for calculation of the main line.</param>
        /// <param name="ma_method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="ma_shift">[in] MA shift. Indicator line offset relate to the chart by timeframe.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="deviation">[in] Percent deviation from the main line.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of enumeration value (0 - MODE_MAIN, 1 - MODE_UPPER, 2 - MODE_LOWER).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iEnvelopes (string symbol, int timeframe, int ma_period, int ma_method, int ma_shift, int applied_price, double deviation, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(ma_period);
            parameters.Add(ma_method);
            parameters.Add(ma_shift);
            parameters.Add(applied_price);
            parameters.Add(deviation);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iEnvelopes, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iEnvelopesOnArray
        /// Description: Calculates the Envelopes indicator on data, stored in array, and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ienvelopesonarray.html
        /// </summary>
        /// <param name="array[]">[in] Array with data.</param>
        /// <param name="total">[in] The number of items to be counted. 0 means the whole array.</param>
        /// <param name="ma_period">[in] Averaging period for calculation of the main line.</param>
        /// <param name="ma_method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="ma_shift">[in] MA shift. Indicator line offset relate to the chart by timeframe.</param>
        /// <param name="deviation">[in] Percent deviation from the main line.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of enumeration value (0 - MODE_MAIN, 1 - MODE_UPPER, 2 - MODE_LOWER).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iEnvelopesOnArray (double array[], int total, int ma_period, int ma_method, int ma_shift, double deviation, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(total);
            parameters.Add(ma_period);
            parameters.Add(ma_method);
            parameters.Add(ma_shift);
            parameters.Add(deviation);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iEnvelopesOnArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iForce
        /// Description: Calculates the Force Index indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iforce.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="ma_method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iForce (string symbol, int timeframe, int period, int ma_method, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(ma_method);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iForce, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iFractals
        /// Description: Calculates the Fractals indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ifractals.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of the enumeration value.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iFractals (string symbol, int timeframe, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iFractals, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iGator
        /// Description: Calculates the Gator oscillator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/igator.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="jaw_period">[in] Blue line averaging period (Alligator's Jaw).</param>
        /// <param name="jaw_shift">[in] Blue line shift relative to the chart.</param>
        /// <param name="teeth_period">[in] Red line averaging period (Alligator's Teeth).</param>
        /// <param name="teeth_shift">[in] Red line shift relative to the chart.</param>
        /// <param name="lips_period">[in] Green line averaging period (Alligator's Lips).</param>
        /// <param name="lips_shift">[in] Green line shift relative to the chart.</param>
        /// <param name="ma_method">[in] MA method. It can be any of enumeration value.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of enumeration value.</param>
        /// <param name="shift">MODE_GATORJAW - blue line (Jaw line),MODE_GATORTEETH - red line (Teeth line),MODE_GATORLIPS - green line (Lips line).</param>
        public double iGator (string symbol, int timeframe, int jaw_period, int jaw_shift, int teeth_period, int teeth_shift, int lips_period, int lips_shift, int ma_method, int applied_price, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(jaw_period);
            parameters.Add(jaw_shift);
            parameters.Add(teeth_period);
            parameters.Add(teeth_shift);
            parameters.Add(lips_period);
            parameters.Add(lips_shift);
            parameters.Add(ma_method);
            parameters.Add(applied_price);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iGator, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iIchimoku
        /// Description: Calculates the Ichimoku Kinko Hyo indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iichimoku.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="tenkan_sen">[in] Tenkan Sen averaging period.</param>
        /// <param name="kijun_sen">[in] Kijun Sen averaging period.</param>
        /// <param name="senkou_span_b">[in] Senkou SpanB averaging period.</param>
        /// <param name="mode">[in] Source of data. It can be one of the enumeration (1 - MODE_TENKANSEN, 2 - MODE_KIJUNSEN, 3 - MODE_SENKOUSPANA, 4 - MODE_SENKOUSPANB, 5 - MODE_CHIKOUSPAN).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iIchimoku (string symbol, int timeframe, int tenkan_sen, int kijun_sen, int senkou_span_b, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(tenkan_sen);
            parameters.Add(kijun_sen);
            parameters.Add(senkou_span_b);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iIchimoku, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iBWMFI
        /// Description: Calculates the Market Facilitation Index indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ibwmfi.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iBWMFI (string symbol, int timeframe, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iBWMFI, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iMomentum
        /// Description: Calculates the Momentum indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/imomentum.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period (amount of bars) for calculation of price changes.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iMomentum (string symbol, int timeframe, int period, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iMomentum, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iMomentumOnArray
        /// Description: Calculates the Momentum indicator on data, stored in array, and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/imomentumonarray.html
        /// </summary>
        /// <param name="array[]">[in] Array with data.</param>
        /// <param name="total">[in] The number of items to be counted. 0 means the whole array.</param>
        /// <param name="period">[in] Averaging period (amount of bars) for calculation of price changes.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iMomentumOnArray (double array[], int total, int period, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(total);
            parameters.Add(period);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iMomentumOnArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iMFI
        /// Description: Calculates the Money Flow Index indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/imfi.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Period (amount of bars) for calculation of the indicator.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iMFI (string symbol, int timeframe, int period, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iMFI, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iMA
        /// Description: Calculates the Moving Average indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/ima.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="ma_period">[in] Averaging period for calculation.</param>
        /// <param name="ma_shift">[in] MA shift. Indicators line offset relate to the chart by timeframe.</param>
        /// <param name="ma_method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iMA (string symbol, int timeframe, int ma_period, int ma_shift, int ma_method, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(ma_period);
            parameters.Add(ma_shift);
            parameters.Add(ma_method);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iMA, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iMAOnArray
        /// Description: Calculates the Moving Average indicator on data, stored in array, and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/imaonarray.html
        /// </summary>
        /// <param name="array[]">[in] Array with data.</param>
        /// <param name="total">[in] The number of items to be counted. 0 means the whole array.</param>
        /// <param name="ma_period">[in] Averaging period for calculation.</param>
        /// <param name="ma_shift">[in] MA shift. Indicators line offset relate to the chart by timeframe.</param>
        /// <param name="ma_method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iMAOnArray (double array[], int total, int ma_period, int ma_shift, int ma_method, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(total);
            parameters.Add(ma_period);
            parameters.Add(ma_shift);
            parameters.Add(ma_method);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iMAOnArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iOsMA
        /// Description: iOsMA
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iosma.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="fast_ema_period">[in] Fast EMA averaging period.</param>
        /// <param name="slow_ema_period">[in] Slow EMA averaging period.</param>
        /// <param name="signal_period">[in] Signal line averaging period.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iOsMA (string symbol, int timeframe, int fast_ema_period, int slow_ema_period, int signal_period, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(fast_ema_period);
            parameters.Add(slow_ema_period);
            parameters.Add(signal_period);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iOsMA, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iMACD
        /// Description: Calculates the Moving Averages Convergence/Divergence indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/imacd.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="fast_ema_period">[in] Fast EMA averaging period.</param>
        /// <param name="slow_ema_period">[in] Slow EMA averaging period.</param>
        /// <param name="signal_period">[in] Signal line averaging period.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="mode">[in] Indicator line index. It can be one of the enumeration values (0-MODE_MAIN, 1-MODE_SIGNAL).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iMACD (string symbol, int timeframe, int fast_ema_period, int slow_ema_period, int signal_period, int applied_price, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(fast_ema_period);
            parameters.Add(slow_ema_period);
            parameters.Add(signal_period);
            parameters.Add(applied_price);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iMACD, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iOBV
        /// Description: Calculates the On Balance Volume indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iobv.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iOBV (string symbol, int timeframe, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iOBV, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iSAR
        /// Description: Calculates the Parabolic Stop and Reverse system indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/isar.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="step">[in] The step of price increment, usually 0.02.</param>
        /// <param name="maximum">[in] The maximum step, usually 0.2.</param>
        public double iSAR (string symbol, int timeframe, double step, double maximum)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(step);
            parameters.Add(maximum);
            
            CommandManager.getInstance().ExecCommand(Command.iSAR, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iRSI
        /// Description: Calculates the Relative Strength Index indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/irsi.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iRSI (string symbol, int timeframe, int period, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iRSI, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iRSIOnArray
        /// Description: Calculates the Relative Strength Index indicator on data, stored in array, and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/irsionarray.html
        /// </summary>
        /// <param name="array[]">[in] Array with data.</param>
        /// <param name="total">[in] The number of items to be counted. 0 means the whole array.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iRSIOnArray (double array[], int total, int period, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(total);
            parameters.Add(period);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iRSIOnArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iRVI
        /// Description: Calculates the Relative Vigor Index indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/irvi.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of enumeration value.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iRVI (string symbol, int timeframe, int period, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iRVI, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iStdDev
        /// Description: Calculates the Standard Deviation indicator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/istddev.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="ma_period">[in] Moving Average period.</param>
        /// <param name="ma_shift">[in] Moving Average shift.</param>
        /// <param name="ma_method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="applied_price">[in] Applied price. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iStdDev (string symbol, int timeframe, int ma_period, int ma_shift, int ma_method, int applied_price, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(ma_period);
            parameters.Add(ma_shift);
            parameters.Add(ma_method);
            parameters.Add(applied_price);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iStdDev, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iStdDevOnArray
        /// Description: Calculates the Standard Deviation indicator on data, stored in array, and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/istddevonarray.html
        /// </summary>
        /// <param name="array[]">[in] Array with data.</param>
        /// <param name="total">[in] The number of items to be counted. 0 means the whole array.</param>
        /// <param name="ma_period">[in] Moving Average period.</param>
        /// <param name="ma_shift">[in] Moving Average shift.</param>
        /// <param name="ma_method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iStdDevOnArray (double array[], int total, int ma_period, int ma_shift, int ma_method, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(array[]);
            parameters.Add(total);
            parameters.Add(ma_period);
            parameters.Add(ma_shift);
            parameters.Add(ma_method);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iStdDevOnArray, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iStochastic
        /// Description: Calculates the Stochastic Oscillator and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/istochastic.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="Kperiod">[in] Period of the %K line.</param>
        /// <param name="Dperiod">[in] Period of the %D line.</param>
        /// <param name="slowing">[in] Slowing value.</param>
        /// <param name="method">[in] Moving Average method. It can be any of enumeration values.</param>
        /// <param name="price_field">[in] Price field parameter. Can be one of this values: 0 - Low/High or 1 - Close/Close.</param>
        /// <param name="mode">[in] Indicator line index. It can be any of the enumeration value (0 - MODE_MAIN, 1 - MODE_SIGNAL).</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iStochastic (string symbol, int timeframe, int Kperiod, int Dperiod, int slowing, int method, int price_field, int mode, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(Kperiod);
            parameters.Add(Dperiod);
            parameters.Add(slowing);
            parameters.Add(method);
            parameters.Add(price_field);
            parameters.Add(mode);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iStochastic, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

        /// <summary>
        /// Function: iWPR
        /// Description: Calculates the Larry Williams' Percent Range and returns its value.
        /// URL: http://mm.l/mql4/docs.mql4.com/indicators/iwpr.html
        /// </summary>
        /// <param name="symbol">[in] Symbol name on the data of which the indicator will be calculated. means the current symbol.</param>
        /// <param name="timeframe">[in] Timeframe. It can be any of enumeration values. 0 means the current chart timeframe.</param>
        /// <param name="period">[in] Averaging period for calculation.</param>
        /// <param name="shift">[in] Index of the value taken from the indicator buffer (shift relative to the current bar the given amount of periods ago).</param>
        public double iWPR (string symbol, int timeframe, int period, int shift)
        {
            List<Object> parameters = new List<Object>();
            parameters.Add(symbol);
            parameters.Add(timeframe);
            parameters.Add(period);
            parameters.Add(shift);
            
            CommandManager.getInstance().ExecCommand(Command.iWPR, parameters);
            while (CommandManager.getInstance().IsCommandRunning()) Thread.Sleep(1);
            return (double) CommandManager.getInstance().GetCommandResult();
        }

    }
}