using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace StormLibSharp.Native
{
    /// <summary>
    /// AddFileCallback
    /// </summary>
    /// <param name="pvUserData">User data pointer that has been passed to SFileSetAddFileCallback.</param>
    /// <param name="dwBytesWritten">Contains number of bytes that has already been written to the MPQ</param>
    /// <param name="dwTotalBytes">Contains total number of bytes to be written to the MPQ. It is the size of the file being added.</param>
    /// <param name="bFinalCall">If this parameter is true, it means that the operation is complete and succeeded. It also means that this is the last call to the callback function.</param>
    public delegate void SFILE_ADDFILE_CALLBACK(IntPtr pvUserData, uint dwBytesWritten, uint dwTotalBytes, [MarshalAs(UnmanagedType.I1)] bool bFinalCall);

    /// <summary>
    /// CompactCallback
    /// </summary>
    /// <param name="pvUserData">User data pointer that has been passed to SFileSetCompactCallback.</param>
    /// <param name="dwWorkType">Contains identifier of the work that is currently being done. </param>
    /// <param name="BytesProcessed">Pointer to LARGE_INTEGER, indicating what part of the archive has already been compacted.</param>
    /// <param name="TotalBytes">Pointer to LARGE_INTEGER, containing total number of bytes that has to be compacted.</param>
    public delegate void SFILE_COMPACT_CALLBACK(IntPtr pvUserData, uint dwWorkType, uint BytesProcessed, uint TotalBytes);

    #region Struct
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct OVERLAPPED
    {
        public uint Internal;

        public uint InternalHigh;

        public Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196 Union1;

        public System.IntPtr hEvent;
    }

    [StructLayoutAttribute(LayoutKind.Explicit)]
    public struct Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196
    {
        [FieldOffset(0)]
        public Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6 Struct1;

        [FieldOffset(0)]
        public IntPtr Pointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6
    {
        public uint Offset;

        public uint OffsetHigh;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TBitArray
    {
        public uint NumberOfBits;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Elements;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TMPQUserData
    {
        public uint dwID;

        public uint cbUserDataSize;

        public uint dwHeaderOffs;

        public uint cbUserDataHeader;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TMPQHeader
    {
        public uint dwID;

        public uint dwHeaderSize;

        public uint dwArchiveSize;

        public ushort wFormatVersion;

        public ushort wSectorSize;

        public uint dwHashTablePos;

        public uint dwBlockTablePos;

        public uint dwHashTableSize;

        public uint dwBlockTableSize;

        public uint HiBlockTablePos64;

        public ushort wHashTablePosHi;

        public ushort wBlockTablePosHi;

        public uint ArchiveSize64;

        public uint BetTablePos64;

        public uint HetTablePos64;

        public uint HashTableSize64;

        public uint BlockTableSize64;

        public uint HiBlockTableSize64;

        public uint HetTableSize64;

        public uint BetTableSize64;

        public uint dwRawChunkSize;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string MD5_BlockTable;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string MD5_HashTable;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string MD5_HiBlockTable;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string MD5_BetTable;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string MD5_HetTable;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string MD5_MpqHeader;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TMPQHash
    {
        public uint dwName1;

        public uint dwName2;

        public ushort lcLocale;

        public ushort wPlatform;

        public uint dwBlockIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TMPQBlock
    {
        public uint dwFilePos;

        public uint dwCSize;

        public uint dwFSize;

        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TPatchInfo
    {
        public uint dwLength;

        public uint dwFlags;

        public uint dwDataSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] md5;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TPatchHeader
    {
        public uint dwSignature;

        public uint dwSizeOfPatchData;

        public uint dwSizeBeforePatch;

        public uint dwSizeAfterPatch;

        public uint dwMD5;

        public uint dwMd5BlockSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] md5_before_patch;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] md5_after_patch;

        public uint dwXFRM;

        public uint dwXfrmBlockSize;

        public uint dwPatchType;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TFileEntry
    {
        public uint ByteOffset;

        public uint FileTime;

        public uint BetHash;

        public uint dwHashIndex;

        public uint dwHetIndex;

        public uint dwFileSize;

        public uint dwCmpSize;

        public uint dwFlags;

        public ushort lcLocale;

        public ushort wPlatform;

        public uint dwCrc32;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string md5;

        public IntPtr szFileName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TMPQHetTable
    {
        public IntPtr pBetIndexes;

        public IntPtr pHetHashes;

        public uint AndMask64;

        public uint OrMask64;

        public uint dwIndexSizeTotal;

        public uint dwIndexSizeExtra;

        public uint dwIndexSize;

        public uint dwMaxFileCount;

        public uint dwHashTableSize;

        public uint dwHashBitSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TMPQBetTable
    {
        public IntPtr pBetHashes;

        public IntPtr pFileTable;

        public IntPtr pFileFlags;

        public uint dwTableEntrySize;

        public uint dwBitIndex_FilePos;

        public uint dwBitIndex_FileSize;

        public uint dwBitIndex_CmpSize;

        public uint dwBitIndex_FlagIndex;

        public uint dwBitIndex_Unknown;

        public uint dwBitCount_FilePos;

        public uint dwBitCount_FileSize;

        public uint dwBitCount_CmpSize;

        public uint dwBitCount_FlagIndex;

        public uint dwBitCount_Unknown;

        public uint dwBetHashSizeTotal;

        public uint dwBetHashSizeExtra;

        public uint dwBetHashSize;

        public uint dwMaxFileCount;

        public uint dwFlagCount;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SFILE_FIND_DATA
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string cFileName;

        public IntPtr szPlainName;

        public uint dwHashIndex;

        public uint dwBlockIndex;

        public uint dwFileSize;

        public uint dwFileFlags;

        public uint dwCompSize;

        public uint dwFileTimeLo;

        public uint dwFileTimeHi;

        public uint lcLocale;
    } 
    #endregion

    public delegate uint SFILESETLOCALE(uint param0);

    public delegate bool SFILEOPENARCHIVE([In,MarshalAs(UnmanagedType.LPStr)] string param0, uint param1, uint param2, ref IntPtr param3);

    public delegate bool SFILECLOSEARCHIVE(IntPtr param0);

    public delegate bool SFILEOPENFILEEX(IntPtr param0, [In,MarshalAs(UnmanagedType.LPStr)] string param1, uint param2, ref IntPtr param3);

    public delegate bool SFILECLOSEFILE(IntPtr param0);

    public delegate uint SFILEGETFILESIZE(IntPtr param0, ref uint param1);

    public delegate uint SFILESETFILEPOINTER(IntPtr param0, int param1, ref int param2, uint param3);

    public delegate bool SFILEREADFILE(IntPtr param0, IntPtr param1, uint param2, ref uint param3, IntPtr param4);

    public partial class NativeMethods
    {
        #region Manipulating MPQ archives
        /// <summary>
        /// SFileGetGlobalFlags
        /// </summary>
        /// <returns></returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileGetGlobalFlags")]
        public static extern uint SFileGetGlobalFlags();

        /// <summary>
        /// SFileSetGlobalFlags
        /// </summary>
        /// <param name="dwNewFlags"></param>
        /// <returns></returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileSetGlobalFlags")]
        public static extern uint SFileSetGlobalFlags(uint dwNewFlags);

        /// <summary>
        /// Changes default locale ID for adding new files
        /// http://www.zezula.net/en/mpq/stormlib/sfilesetlocale.html
        /// </summary>
        /// <param name="lcNewLocale">Locale ID to be set.</param>
        /// <returns>The function never fails and always returns lcNewLocale.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileSetLocale")]
        public static extern uint SFileSetLocale(uint lcNewLocale);

        /// <summary>
        /// Returns current locale ID for adding new files
        /// http://www.zezula.net/en/mpq/stormlib/sfilegetlocale.html
        /// </summary>
        /// <returns>The function never fails and always returns current locale ID.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileGetLocale")]
        public static extern uint SFileGetLocale();

        /// <summary>
        /// Opens a MPQ archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileopenarchive.html
        /// </summary>
        /// <param name="szMpqName">Archive file name to open.</param>
        /// <param name="dwPriority">Priority of the archive for later search. StormLib does not use this parameter, set it to zero. </param>
        /// <param name="dwFlags">Flags that specify additional options about how to open the file.</param>
        /// <param name="phMpq">Pointer to a variable of HANDLE type, where the opened archive handle will be stored. </param>
        /// <returns>When the function succeeds, it returns nonzero and phMPQ contains the handle of the opened archive. When the archive cannot be open, function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileOpenArchive")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileOpenArchive([In, MarshalAs(UnmanagedType.LPStr)] string szMpqName, uint dwPriority, uint dwFlags, ref IntPtr phMpq);

        /// <summary>
        /// SFileCreateArchive
        /// http://www.zezula.net/en/mpq/stormlib/sfilecreatearchive.html
        /// </summary>
        /// <param name="szMpqName">Archive file name to be created.</param>
        /// <param name="dwFlags">Specifies additional flags for MPQ creation process. </param>
        /// <param name="dwMaxFileCount">File count limit. The value must be in range of HASH_TABLE_SIZE_MIN (0x04) and HASH_TABLE_SIZE_MAX (0x80000). StormLib will automatically calculate size of hash tables and block tables from this value.</param>
        /// <param name="phMpq">Pointer to a variable of HANDLE type, where the opened archive handle will be stored. </param>
        /// <returns>When the function succeeds, it returns nonzero and phMPQ contains the handle of the new archive. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileCreateArchive")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileCreateArchive([In, MarshalAs(UnmanagedType.LPStr)] string szMpqName, uint dwFlags, uint dwMaxFileCount, ref IntPtr phMpq);

        /// <summary>
        /// Flushes all unsaved data to the disk
        /// http://www.zezula.net/en/mpq/stormlib/sfileflusharchive.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileFlushArchive")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileFlushArchive(IntPtr hMpq);

        /// <summary>
        /// Closes an open archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileclosearchive.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileCloseArchive")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileCloseArchive(IntPtr hMpq);

        /// <summary>
        /// Adds another list file to the open archive in order to improve searching
        /// http://www.zezula.net/en/mpq/stormlib/sfileaddlistfile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. </param>
        /// <param name="szListFile">Listfile name to add. If this parameter is NULL, the function adds the internal listfile from the MPQ, if present. Adding the same listfile multiple times has no effect.</param>
        /// <returns>When the function succeeds, it returns ERROR_SUCCESS. On an error, the function returns error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileAddListFile")]
        public static extern int SFileAddListFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szListFile);

        /// <summary>
        /// Compacts (rebuilds) the archive, freeing all gaps that were created by write operations
        /// http://www.zezula.net/en/mpq/stormlib/sfilecompactarchive.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. The MPQ must have been open by SFileOpenArchive or created by SFileCreateArchive.</param>
        /// <param name="szListFile"> Allows to specify an additional listfile, that will be used together with internal listfile. Can be NULL.</param>
        /// <param name="bReserved">Not used, set to zero.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImportAttribute("StormLib.dll", EntryPoint = "SFileCompactArchive")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileCompactArchive(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szListFile = null, [MarshalAs(UnmanagedType.I1)] bool bReserved = false);

        /// <summary>
        /// Allows to set a callback function for archive compacting
        /// http://www.zezula.net/en/mpq/stormlib/sfilesetcompactcallback.html
        /// </summary>
        /// <param name="hMpq">Handle to the MPQ that will be compacted. Current version of StormLib ignores the parameter, but it is recommended to set it to the handle of the archive.</param>
        /// <param name="CompactCB">Pointer to the callback function.</param>
        /// <param name="pvData">User defined data that will be passed to the callback function. </param>
        /// <returns>The function never fails and always sets the callback.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileSetCompactCallback")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileSetCompactCallback(IntPtr hMpq, SFILE_COMPACT_CALLBACK CompactCB, IntPtr pvData);

        /// Return Type: boolean
        ///hMpq: HANDLE->void*
        ///dwMaxFileCount: DWORD->unsigned int
        [DllImport("StormLib.dll", EntryPoint = "SFileSetMaxFileCount")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileSetMaxFileCount(IntPtr hMpq, uint dwMaxFileCount);

        /// Return Type: DWORD->unsigned int
        ///hMpq: HANDLE->void*
        [DllImport("StormLib.dll", EntryPoint = "SFileGetAttributes")]
        public static extern uint SFileGetAttributes(IntPtr hMpq);

        /// Return Type: boolean
        ///hMpq: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("StormLib.dll", EntryPoint = "SFileSetAttributes")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileSetAttributes(IntPtr hMpq, uint dwFlags);


        /// Return Type: boolean
        ///hMpq: HANDLE->void*
        ///szFileName: char*
        [DllImport("StormLib.dll", EntryPoint = "SFileUpdateFileAttributes")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileUpdateFileAttributes(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName); 
        #endregion

        #region Using patched archives
        /// <summary>
        /// Adds a patch archive for an existing open archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileopenpatcharchive.html
        /// </summary>
        /// <param name="hMpq">Handle to a MPQ that serves as primary MPQ when patched.</param>
        /// <param name="szPatchMpqName">Name of the patch MPQ to be added.</param>
        /// <param name="szPatchPathPrefix">Pointer to patch prefix to file names.</param>
        /// <param name="dwFlags">Reserved for future use.</param>
        /// <returns>When the function succeeds, it returns nonzero. When the archive cannot be added as patch archive, function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileOpenPatchArchive")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileOpenPatchArchive(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szPatchMpqName, [In, MarshalAs(UnmanagedType.LPStr)] string szPatchPathPrefix, uint dwFlags);

        /// <summary>
        /// Determines if the open MPQ has patches
        /// http://www.zezula.net/en/mpq/stormlib/sfileispatcharchive.html
        /// </summary>
        /// <param name="hMpq">Handle to a MPQ in question.</param>
        /// <returns>The function returns true, when there is at least one patch added to the MPQ. Otherwise, it returns false.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileIsPatchedArchive")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileIsPatchedArchive(IntPtr hMpq); 
        #endregion

        #region Reading files
        /// <summary>
        /// Opens a file from MPQ archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileopenfileex.html
        /// </summary>
        /// <param name="hMpq">Handle to an open archive.</param>
        /// <param name="szFileName">Name or index of the file to open.</param>
        /// <param name="dwSearchScope">Value that specifies how exactly the file should be open.</param>
        /// <param name="phFile">Pointer to a variable of HANDLE type, that will receive HANDLE to the open file.</param>
        /// <returns>When the function succeeds, it returns nonzero and phFile contains the handle of the opened file. When the file cannot be open, function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileOpenFileEx")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileOpenFileEx(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName, uint dwSearchScope, ref IntPtr phFile);

        /// <summary>
        /// Retrieves a size of the file within archive
        /// http://www.zezula.net/en/mpq/stormlib/sfilegetfilesize.html
        /// </summary>
        /// <param name="hFile">Handle to an open file. The file handle must have been created by SFileOpenFileEx.</param>
        /// <param name="pdwFileSizeHigh">Receives high 32 bits of the a file size.</param>
        /// <returns>When the function succeeds, it returns lower 32-bit of the file size. On an error, it returns SFILE_INVALID_SIZE and GetLastError returns an error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileGetFileSize")]
        public static extern uint SFileGetFileSize(IntPtr hFile, ref uint pdwFileSizeHigh);

        /// <summary>
        /// Sets a new position within archive file
        /// http://www.zezula.net/en/mpq/stormlib/sfilesetfilepointer.html
        /// </summary>
        /// <param name="hFile">Handle to an open file. The file handle must have been created by SFileOpenFileEx.</param>
        /// <param name="lFilePos">Low 32 bits of new position in the file.</param>
        /// <param name="plFilePosHigh">Pointer to a high 32 bits of new position in the file.</param>
        /// <param name="dwMoveMethod">The starting point for the file pointer move.</param>
        /// <returns>When the function succeeds, it returns lower 32-bit of the file size. On an error, it returns SFILE_INVALID_SIZE and GetLastError returns an error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileSetFilePointer")]
        public static extern uint SFileSetFilePointer(IntPtr hFile, int lFilePos, ref int plFilePosHigh, uint dwMoveMethod);

        /// <summary>
        /// Reads data from the file
        /// http://www.zezula.net/en/mpq/stormlib/sfilereadfile.html
        /// </summary>
        /// <param name="hFile">Handle to an open file. The file handle must have been created by SFileOpenFileEx.</param>
        /// <param name="lpBuffer">Pointer to buffer that will receive loaded data. The buffer size must be greater or equal to dwToRead.</param>
        /// <param name="dwToRead">Number of bytes to be read.</param>
        /// <param name="pdwRead">Pointer to DWORD that will receive number of bytes read.</param>
        /// <param name="lpOverlapped">If hFile is handle to a local disk file, lpOverlapped is passed to ReadFile. Otherwise not used.</param>
        /// <returns>When all requested bytes have been read, the function returns true.When less than requested bytes have been read, the function returns false and GetLastError returns ERROR_HANDLE_EOF. If an error occured, the function returns false and GetLastError returns an error code different from ERROR_HANDLE_EOF. </returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileReadFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileReadFile(IntPtr hFile, IntPtr lpBuffer, uint dwToRead, ref uint pdwRead, ref OVERLAPPED lpOverlapped);

        /// <summary>
        /// Closes an open file
        /// http://www.zezula.net/en/mpq/stormlib/sfileclosefile.html
        /// </summary>
        /// <param name="hFile">Handle to an open file.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileCloseFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileCloseFile(IntPtr hFile);

        /// <summary>
        /// Quick check if the file exists within MPQ archive, without opening it
        /// http://www.zezula.net/en/mpq/stormlib/sfilehasfile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ.</param>
        /// <param name="szFileName">Name of the file to check.</param>
        /// <returns>When the file is present in the MPQ, function returns true. When the file is not present in the MPQ archive, the function returns false and GetLastError returns ERROR_FILE_NOT_FOUND. If an error occured, the function returns false and GetLastError returns an error code different than ERROR_FILE_NOT_FOUND.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileHasFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileHasFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName);

        /// <summary>
        /// Retrieves name of an open file
        /// http://www.zezula.net/en/mpq/stormlib/sfilegetfilename.html
        /// </summary>
        /// <param name="hFile">Handle to an open file. The file handle must have been created by SFileOpenFileEx.</param>
        /// <param name="szFileName">Receives the file name. The buffer must be at least MAX_PATH characters long.</param>
        /// <returns>When the function succeeds, it returns true and buffer pointed by szFileName contains name of the file. On an error, the function returns false and GetLastError returns an error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileGetFileName")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileGetFileName(IntPtr hFile, IntPtr szFileName);

        /// <summary>
        /// Retrieves an information about open file or archive
        /// http://www.zezula.net/en/mpq/stormlib/sfilegetfileinfo.html
        /// </summary>
        /// <param name="hMpqOrFile">Handle to an open file or to an open MPQ archive, depending on the value of dwInfoType.</param>
        /// <param name="dwInfoType">Type of information to retrieve. See Return Value for more information.</param>
        /// <param name="pvFileInfo">Pointer to buffer where to store the required information.</param>
        /// <param name="cbFileInfo">Size of the buffer pointed by pvFileInfo.</param>
        /// <param name="pcbLengthNeeded">Size, in bytes, needed to store the information into pvFileInfo.</param>
        /// <returns>When the function succeeds, it returns true. On an error, the function returns false and GetLastError returns error code. Possible error codes may be ERROR_INVALID_PARAMETER (unknown file info type) or ERROR_INSUFFICIENT_BUFFER (not enough space in the supplied buffer).</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileGetFileInfo")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileGetFileInfo(System.IntPtr hMpqOrFile, uint dwInfoType, System.IntPtr pvFileInfo, uint cbFileInfo, ref uint pcbLengthNeeded);

        /// <summary>
        /// Extracts a file from MPQ to the local drive
        /// http://www.zezula.net/en/mpq/stormlib/sfileextractfile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ archive.</param>
        /// <param name="szToExtract">Name of a file within the MPQ that is to be extracted.</param>
        /// <param name="szExtracted">Specifies the name of a local file that will be created and will contain data from the extracted MPQ file.</param>
        /// <param name="dwSearchScope"></param>
        /// <returns>If the MPQ file has been successfully extracted into the target file, the function returns true. On an error, the function returns false and GetLastError returns an error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileExtractFile")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool SFileExtractFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szToExtract, [In, MarshalAs(UnmanagedType.LPStr)] string szExtracted, uint dwSearchScope = NativeConstants.SFILE_OPEN_FROM_MPQ); 
        #endregion

        #region File and archive verification
        /// <summary>
        /// Verifies a file against its extended attributes
        /// http://www.zezula.net/en/mpq/stormlib/sfileverifyfile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ archive. </param>
        /// <param name="szFileName">Name of a file to verify.</param>
        /// <param name="dwFlags">Specifies what to verify.</param>
        /// <returns>Return value is zero when no problerms were found. Otherwise, return value is a bit mask consisting of the possible found problems</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileVerifyFile")]
        public static extern uint SFileVerifyFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName, uint dwFlags);

        /// <summary>
        /// SFileVerifyRawData
        /// 
        /// </summary>
        /// <param name="hMpq"></param>
        /// <param name="dwWhatToVerify"></param>
        /// <param name="szFileName"></param>
        /// <returns></returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileVerifyRawData")]
        public static extern int SFileVerifyRawData(IntPtr hMpq, uint dwWhatToVerify, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName);

        /// <summary>
        /// Verifies the digital signature of an archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileverifyarchive.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ archive to be verified.</param>
        /// <returns>Return value can be one of the values</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileVerifyArchive")]
        public static extern uint SFileVerifyArchive(IntPtr hMpq); 
        #endregion

        #region File searching
        /// <summary>
        /// Finds a first file matching the specification
        /// http://www.zezula.net/en/mpq/stormlib/sfilefindfirstfile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open archive.</param>
        /// <param name="szMask">Name of the search mask. "*" will return all files.</param>
        /// <param name="lpFindFileData">Pointer to SFILE_FIND_DATA structure that will receive information about the found file.</param>
        /// <param name="szListFile">Name of an extra list file that will be used for searching. Note that SFileAddListFile is called internally. The internal listfile in the MPQ is always used (if exists). This parameter can be NULL.</param>
        /// <returns>When the function succeeds, it returns handle to the MPQ search object and the SFILE_FIND_DATA structure is filled with information about the file. On an error, the function returns NULL and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileFindFirstFile")]
        public static extern IntPtr SFileFindFirstFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szMask, ref SFILE_FIND_DATA lpFindFileData, [In, MarshalAs(UnmanagedType.LPStr)] string szListFile);

        /// <summary>
        /// Finds a next file matching the specification
        /// http://www.zezula.net/en/mpq/stormlib/sfilefindnextfile.html
        /// </summary>
        /// <param name="hFind">Search handle. Must have been obtained by call to SFileFindFirstFile.</param>
        /// <param name="lpFindFileData">Pointer to SFILE_FIND_DATA structure that will receive information about the found file. For layout of the structure, see SFileFindFirstFile.</param>
        /// <returns>When the function succeeds, it returns nonzero and the SFILE_FIND_DATA structure is filled with information about the file. On an error, the function returns zero and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileFindNextFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileFindNextFile(IntPtr hFind, ref SFILE_FIND_DATA lpFindFileData);

        /// <summary>
        /// Stops searching in MPQ
        /// http://www.zezula.net/en/mpq/stormlib/sfilefindclose.html
        /// </summary>
        /// <param name="hFind">Search handle. Must have been obtained by call to SFileFindFirstFile.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns zero and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileFindClose")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileFindClose(IntPtr hFind);

        /// <summary>
        /// Finds a first line in the listfile that matches the specification
        /// http://www.zezula.net/en/mpq/stormlib/slistfilefindfirstfile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open archive. This parameter must only be valid if szListFile is NULL.</param>
        /// <param name="szListFile">Name of the listfile that will be used for searching. If this parameter is NULL, the function searches the MPQ internal listfile (if any).</param>
        /// <param name="szMask">Name of the search mask. "*" will return all files.</param>
        /// <param name="lpFindFileData">Pointer to SFILE_FIND_DATA structure that will receive name of the found file. For layout of this structure, see SFileFindFirstFile.</param>
        /// <returns>When the function succeeds, it returns handle to the MPQ search object and the cFileName member of SFILE_FIND_DATA structure is filled with name of the file. On an error, the function returns NULL and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SListFileFindFirstFile")]
        public static extern IntPtr SListFileFindFirstFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szListFile, [In, MarshalAs(UnmanagedType.LPStr)] string szMask, ref SFILE_FIND_DATA lpFindFileData);

        /// <summary>
        /// Finds a next line in the listfile that matches the specification
        /// http://www.zezula.net/en/mpq/stormlib/slistfilefindnextfile.html
        /// </summary>
        /// <param name="hFind">Search handle. Must have been obtained by call to SListFileFindFirstFile.</param>
        /// <param name="lpFindFileData">Pointer to SFILE_FIND_DATA structure that will receive name of the found file. For layout of the structure, see SFileFindFirstFile.</param>
        /// <returns>When the function succeeds, it returns nonzero and the cFileName member of SFILE_FIND_DATA structure is filled with name of the file. On an error, the function returns zero and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SListFileFindNextFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SListFileFindNextFile(IntPtr hFind, ref SFILE_FIND_DATA lpFindFileData);

        /// <summary>
        /// Stops searching in the listfile
        /// http://www.zezula.net/en/mpq/stormlib/slistfilefindclose.html
        /// </summary>
        /// <param name="hFind">Search handle. Must have been obtained by call to SListFileFindFirstFile.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns zero and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SListFileFindClose")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SListFileFindClose(IntPtr hFind);

        /// <summary>
        /// Enumerates all locales for a given file that are in the archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileenumlocales.html
        /// </summary>
        /// <param name="hMpq">Handle to a MPQ.</param>
        /// <param name="szFileName">Name of a file to enumerate the locales.</param>
        /// <param name="plcLocales">An array of LCIDs that will receive locales. This parameter can be NULL if pdwMaxLocales points to zero.</param>
        /// <param name="pdwMaxLocales">On input, this argument must point to a variable that contains maximum number of entries in plcLocales array. On output, this variable receives number of locales that are for the file. This argument cannot be NULL.</param>
        /// <param name="dwSearchScope">Specifies whether szFileName is a file name or a file index. The value of this parameter can either be SFILE_OPEN_FROM_MPQ or SFILE_OPEN_BY_INDEX. See SFileOpenFileEx for more information.</param>
        /// <returns>When the function succeeds, it returns ERROR_SUCCESS. On an error, the function returns an error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileEnumLocales")]
        public static extern int SFileEnumLocales(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName, ref uint plcLocales, ref uint pdwMaxLocales, uint dwSearchScope); 
        #endregion
        
        #region Adding files to MPQ
        /// <summary>
        /// Creates a new file in MPQ and prepares it for writing data
        /// http://www.zezula.net/en/mpq/stormlib/sfilecreatefile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. This handle must have been obtained by calling SFileOpenArchive or SFileCreateArchive.</param>
        /// <param name="szArchivedName">A name under which the file will be stored into the MPQ. </param>
        /// <param name="FileTime">Specifies the file date-time that will be stored into "(attributes)" file in MPQ. This parameter is optional and can be zero.</param>
        /// <param name="dwFileSize">Specifies the size of the data that will be written to the file. This size of the file is set by the call and cannot be changed. The subsequent amount of data written must exactly match the size given by this parameter. </param>
        /// <param name="lcLocale">Specifies the locale for the new file.</param>
        /// <param name="dwFlags">Specifies additional options about how to add the file to the MPQ. For more information about these flags, see SFileAddFileEx.</param>
        /// <param name="phFile">Pointer to a variable of HANDLE type that receives a valid handle. Note that this handle can only be used in call to SFileWriteFile and SFileFinishFile. This handle must never be passed to another file function. Moreover, this handle must always be freed by SFileFinishFile, if not NULL. </param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileCreateFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileCreateFile(IntPtr hMpq, [In,MarshalAs(UnmanagedType.LPStr)] string szArchivedName, uint FileTime, uint dwFileSize, uint lcLocale, uint dwFlags, ref IntPtr phFile);

        /// <summary>
        /// Writes data to the file within MPQ
        /// http://www.zezula.net/en/mpq/stormlib/sfilewritefile.html
        /// </summary>
        /// <param name="hFile">Handle to a new file within MPQ. This handle must have been obtained by calling SFileCreateFile.</param>
        /// <param name="pvData">Pointer to data to be written to the file.</param>
        /// <param name="dwSize">Size of the data that are to be written to the MPQ.</param>
        /// <param name="dwCompression">Specifies the type of data compression that is to be applied to the data, in case the amount of the data will reach size of one file sector. For more information about the available compressions, see SFileAddFileEx.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileWriteFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileWriteFile(IntPtr hFile, IntPtr pvData, uint dwSize, uint dwCompression);

        /// <summary>
        /// Finalizes writing file to the MPQ
        /// http://www.zezula.net/en/mpq/stormlib/sfilefinishfile.html
        /// </summary>
        /// <param name="hFile">Handle to a new file within MPQ. This handle must have been obtained by calling SFileCreateFile. </param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileFinishFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileFinishFile(IntPtr hFile);

        /// <summary>
        /// Adds a data file to the archive (obsolete)
        /// http://www.zezula.net/en/mpq/stormlib/sfileaddfile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. This handle must have been obtained by calling SFileOpenArchive or SFileCreateArchive.</param>
        /// <param name="szFileName">Name of a file to be added to the MPQ.</param>
        /// <param name="szArchivedName">A name under which the file will be stored into the MPQ. This does not have to be the same like the original file name.</param>
        /// <param name="dwFlags">Specifies additional options about how to add the file to the MPQ. For more information about these flags, see SFileAddFileEx.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [Obsolete]
        [DllImport("StormLib.dll", EntryPoint = "SFileAddFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileAddFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName, [In, MarshalAs(UnmanagedType.LPStr)] string szArchivedName, uint dwFlags);

        /// <summary>
        /// Adds a file to the archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileaddfileex.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. This handle must have been obtained by calling SFileOpenArchive or SFileCreateArchive.</param>
        /// <param name="szFileName">Name of a file to be added to the MPQ.</param>
        /// <param name="szArchivedName">A name under which the file will be stored into the MPQ. This does not have to be the same like the original file name.</param>
        /// <param name="dwFlags">Specifies additional options about how to add the file to the MPQ.</param>
        /// <param name="dwCompression">Compression method of the first file block. This parameter is ignored if MPQ_FILE_COMPRESS is not specified in dwFlags.</param>
        /// <param name="dwCompressionNext">Compression method of rest of the file. This parameter optional and is ignored if MPQ_FILE_COMPRESS is not specified in dwFlags.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileAddFileEx")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileAddFileEx(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName, [In, MarshalAs(UnmanagedType.LPStr)] string szArchivedName, uint dwFlags, uint dwCompression, uint dwCompressionNext = 0xFFFFFFFF);

        /// <summary>
        /// Adds a WAVE file to the archive (obsolete)
        /// http://www.zezula.net/en/mpq/stormlib/sfileaddwave.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. This handle must have been obtained by calling SFileOpenArchive or SFileCreateArchive.</param>
        /// <param name="szFileName">Name of a file to be added to the MPQ.</param>
        /// <param name="szArchivedName">A name under which the file will be stored into the MPQ. This does not have to be the same like the original file name.</param>
        /// <param name="dwFlags">Specifies additional options about how to add the file to the MPQ. For more information about these flags, see SFileAddFileEx.</param>
        /// <param name="dwQuality">Specifies quality of WAVE compression. This parameter is ignored if MPQ_FILE_COMPRESS is not specified in dwFlags.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [Obsolete]
        [DllImport("StormLib.dll", EntryPoint = "SFileAddWave")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileAddWave(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName, [In, MarshalAs(UnmanagedType.LPStr)] string szArchivedName, uint dwFlags, uint dwQuality);

        /// <summary>
        /// Deletes a file from MPQ archive
        /// http://www.zezula.net/en/mpq/stormlib/sfileremovefile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. This handle must have been obtained by calling SFileOpenArchive or SFileCreateArchive.</param>
        /// <param name="szFileName">Name of a file to be removed.</param>
        /// <param name="dwSearchScope">Specifies whether szFileName is a file name or a file index. The value of this parameter can either be SFILE_OPEN_FROM_MPQ or SFILE_OPEN_BY_INDEX. See SFileOpenFileEx for more information.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileRemoveFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileRemoveFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szFileName, uint dwSearchScope);

        /// <summary>
        /// Renames a file within MPQ archive
        /// http://www.zezula.net/en/mpq/stormlib/sfilerenamefile.html
        /// </summary>
        /// <param name="hMpq">Handle to an open MPQ. This handle must have been obtained by calling SFileOpenArchive or SFileCreateArchive.</param>
        /// <param name="szOldFileName">Name of a file to be renamed.</param>
        /// <param name="szNewFileName">New name of the file.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileRenameFile")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileRenameFile(IntPtr hMpq, [In, MarshalAs(UnmanagedType.LPStr)] string szOldFileName, [In, MarshalAs(UnmanagedType.LPStr)] string szNewFileName);

        /// <summary>
        /// Changes locale of a file in MPQ archive
        /// http://www.zezula.net/en/mpq/stormlib/sfilesetfilelocale.html
        /// </summary>
        /// <param name="hFile">Handle to the file in the MPQ. This handle must have been obtained by calling SFileOpenFileEx.</param>
        /// <param name="lcNewLocale">New locale ID for the file. For more onformation about locales, see SFileSetLocale.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileSetFileLocale")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileSetFileLocale(IntPtr hFile, uint lcNewLocale);

        /// <summary>
        /// Sets default compression method for adding a data file using SFileAddFile
        /// http://www.zezula.net/en/mpq/stormlib/sfilesetdatacompression.html
        /// </summary>
        /// <param name="DataCompression">Bit mask of data compression.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns false and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileSetDataCompression")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileSetDataCompression(uint DataCompression);

        /// <summary>
        /// Sets callback function that is called to inform the calling application about progress of adding file to the archive
        /// http://www.zezula.net/en/mpq/stormlib/sfilesetaddfilecallback.html
        /// </summary>
        /// <param name="hMpq">Handle to the MPQ that will be compacted. Current version of StormLib ignores the parameter, but it is recommended to set it to the handle of the archive.</param>
        /// <param name="AddFileCB">Pointer to the callback function.</param>
        /// <param name="pvData">User defined data that will be passed to the callback function.</param>
        /// <returns>The function never fails and always sets the callback.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SFileSetAddFileCallback")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SFileSetAddFileCallback(IntPtr hMpq, SFILE_ADDFILE_CALLBACK AddFileCB, IntPtr pvData); 
        #endregion

        #region Compression functions
        /// <summary>
        /// Compresses a data buffer using IMPLODE method (Pkware Data Compression Library)
        /// http://www.zezula.net/en/mpq/stormlib/scompimplode.html
        /// </summary>
        /// <param name="pbOutBuffer">Pointer to buffer where the compressed data will be stored.</param>
        /// <param name="pcbOutBuffer">On call, pointer to the length of the buffer in pbOutBuffer. When finished, this variable receives length of the compressed data.</param>
        /// <param name="pbInBuffer">Pointer to data that are to be imploded.</param>
        /// <param name="cbInBuffer">Length of the data pointed by pbInBuffer.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns FALSE and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SCompImplode")]
        public static extern int SCompImplode(IntPtr pbOutBuffer, ref int pcbOutBuffer, IntPtr pbInBuffer, int cbInBuffer);

        /// <summary>
        /// Decompresses a buffer that has been imploded by SCompImplode
        /// http://www.zezula.net/en/mpq/stormlib/scompexplode.html
        /// </summary>
        /// <param name="pbOutBuffer">Pointer to buffer where the decompressed data will be stored.</param>
        /// <param name="pcbOutBuffer">On call, pointer to the length of the buffer in pbOutBuffer. When finished, this variable receives length of the decompressed data.</param>
        /// <param name="pbInBuffer">Pointer to data that are to be exploded.</param>
        /// <param name="cbInBuffer">Length of the data pointed by pbInBuffer.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns FALSE and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SCompExplode")]
        public static extern int SCompExplode(IntPtr pbOutBuffer, ref int pcbOutBuffer, IntPtr pbInBuffer, int cbInBuffer);

        /// <summary>
        /// Compresses a data buffer using any of the supported MPQ compressions
        /// http://www.zezula.net/en/mpq/stormlib/scompcompress.html
        /// </summary>
        /// <param name="pbOutBuffer">Pointer to buffer where the compressed data will be stored.</param>
        /// <param name="pcbOutBuffer">On call, pointer to the length of the buffer in pbOutBuffer. When finished, this variable receives length of the compressed data.</param>
        /// <param name="pbInBuffer">Pointer to data that are to be imploded.</param>
        /// <param name="cbInBuffer">Length of the data pointed by pbInBuffer.</param>
        /// <param name="uCompressionMask">Bit mask that specifies compression methods to use. For possible values of this parameter, see SFileAddFileEx.</param>
        /// <param name="nCmpType">An extra parameter, specific to compression type. This parameter is only used internally by Huffmann compression when applied after an ADPCM compression.</param>
        /// <param name="nCmpLevel">An extra parameter, specific to compression type. This parameter is used by ADPCM compression and is related to WAVE quality. See Remarks section for additional information.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns FALSE and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SCompCompress")]
        public static extern int SCompCompress(IntPtr pbOutBuffer, ref int pcbOutBuffer, IntPtr pbInBuffer, int cbInBuffer, uint uCompressionMask, int nCmpType, int nCmpLevel);

        /// <summary>
        /// Decompresses a data buffer that has been compressed by SCompCompress
        /// http://www.zezula.net/en/mpq/stormlib/scompdecompress.html
        /// </summary>
        /// <param name="pbOutBuffer">Pointer to buffer where the decompressed data will be stored.</param>
        /// <param name="pcbOutBuffer">On call, pointer to the length of the buffer in pbOutBuffer. When finished, this variable receives length of the decompressed data.</param>
        /// <param name="pbInBuffer">Pointer to data that are to be exploded.</param>
        /// <param name="cbInBuffer">Length of the data pointed by pbInBuffer.</param>
        /// <returns>When the function succeeds, it returns nonzero. On an error, the function returns FALSE and GetLastError gives the error code.</returns>
        [DllImport("StormLib.dll", EntryPoint = "SCompDecompress")]
        public static extern int SCompDecompress(IntPtr pbOutBuffer, ref int pcbOutBuffer, IntPtr pbInBuffer, int cbInBuffer); 
        #endregion

    }
}
