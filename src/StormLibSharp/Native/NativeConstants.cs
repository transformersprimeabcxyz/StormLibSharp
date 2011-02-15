using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StormLibSharp.Native
{
    public class NativeConstants
    {
        /// ID_MPQ -> 0x1A51504D
        public const int ID_MPQ = 441536589;

        /// ID_MPQ_USERDATA -> 0x1B51504D
        public const int ID_MPQ_USERDATA = 458313805;

        /// ERROR_AVI_FILE -> 10000
        public const int ERROR_AVI_FILE = 10000;

        /// ERROR_UNKNOWN_FILE_KEY -> 10001
        public const int ERROR_UNKNOWN_FILE_KEY = 10001;

        /// ERROR_CHECKSUM_ERROR -> 10002
        public const int ERROR_CHECKSUM_ERROR = 10002;

        /// ERROR_INTERNAL_FILE -> 10003
        public const int ERROR_INTERNAL_FILE = 10003;

        /// ERROR_BASE_FILE_MISSING -> 10004
        public const int ERROR_BASE_FILE_MISSING = 10004;

        /// HASH_TABLE_SIZE_MIN -> 0x00000004
        public const int HASH_TABLE_SIZE_MIN = 4;

        /// HASH_TABLE_SIZE_DEFAULT -> 0x00001000
        public const int HASH_TABLE_SIZE_DEFAULT = 4096;

        /// HASH_TABLE_SIZE_MAX -> 0x00080000
        public const int HASH_TABLE_SIZE_MAX = 524288;

        /// HASH_ENTRY_DELETED -> 0xFFFFFFFE
        public const int HASH_ENTRY_DELETED = -2;

        /// HASH_ENTRY_FREE -> 0xFFFFFFFF
        public const int HASH_ENTRY_FREE = -1;

        /// HET_ENTRY_DELETED -> 0x80
        public const int HET_ENTRY_DELETED = 128;

        /// HET_ENTRY_FREE -> 0x00
        public const int HET_ENTRY_FREE = 0;

        /// HASH_STATE_SIZE -> 0x60
        public const int HASH_STATE_SIZE = 96;

        /// MPQ_PATCH_PREFIX_LEN -> 0x20
        public const int MPQ_PATCH_PREFIX_LEN = 32;

        /// STREAM_FLAG_READ_ONLY -> 0x01
        public const int STREAM_FLAG_READ_ONLY = 1;

        /// STREAM_FLAG_PART_FILE -> 0x02
        public const int STREAM_FLAG_PART_FILE = 2;

        /// STREAM_FLAG_ENCRYPTED_FILE -> 0x04
        public const int STREAM_FLAG_ENCRYPTED_FILE = 4;

        /// SFILE_OPEN_HARD_DISK_FILE -> 2
        public const int SFILE_OPEN_HARD_DISK_FILE = 2;

        /// SFILE_OPEN_CDROM_FILE -> 3
        public const int SFILE_OPEN_CDROM_FILE = 3;

        /// SFILE_OPEN_FROM_MPQ -> 0x00000000
        public const int SFILE_OPEN_FROM_MPQ = 0;

        /// SFILE_OPEN_PATCHED_FILE -> 0x00000001
        public const int SFILE_OPEN_PATCHED_FILE = 1;

        /// SFILE_OPEN_BY_INDEX -> 0x00000002
        public const int SFILE_OPEN_BY_INDEX = 2;

        /// SFILE_OPEN_ANY_LOCALE -> 0xFFFFFFFE
        public const int SFILE_OPEN_ANY_LOCALE = -2;

        /// SFILE_OPEN_LOCAL_FILE -> 0xFFFFFFFF
        public const int SFILE_OPEN_LOCAL_FILE = -1;

        /// MPQ_FLAG_READ_ONLY -> 0x00000001
        public const int MPQ_FLAG_READ_ONLY = 1;

        /// MPQ_FLAG_CHANGED -> 0x00000002
        public const int MPQ_FLAG_CHANGED = 2;

        /// MPQ_FLAG_PROTECTED -> 0x00000004
        public const int MPQ_FLAG_PROTECTED = 4;

        /// MPQ_FLAG_CHECK_SECTOR_CRC -> 0x0000008
        public const int MPQ_FLAG_CHECK_SECTOR_CRC = 8;

        /// MPQ_FLAG_NEED_FIX_SIZE -> 0x00000010
        public const int MPQ_FLAG_NEED_FIX_SIZE = 16;

        /// MPQ_FLAG_LISTFILE_VALID -> 0x00000020
        public const int MPQ_FLAG_LISTFILE_VALID = 32;

        /// MPQ_FLAG_ATTRIBS_VALID -> 0x00000040
        public const int MPQ_FLAG_ATTRIBS_VALID = 64;

        /// SFILE_INVALID_SIZE -> 0xFFFFFFFF
        public const int SFILE_INVALID_SIZE = -1;

        /// SFILE_INVALID_POS -> 0xFFFFFFFF
        public const int SFILE_INVALID_POS = -1;

        /// SFILE_INVALID_ATTRIBUTES -> 0xFFFFFFFF
        public const int SFILE_INVALID_ATTRIBUTES = -1;

        /// MPQ_FILE_IMPLODE -> 0x00000100
        public const int MPQ_FILE_IMPLODE = 256;

        /// MPQ_FILE_COMPRESS -> 0x00000200
        public const int MPQ_FILE_COMPRESS = 512;

        /// MPQ_FILE_COMPRESSED -> 0x0000FF00
        public const int MPQ_FILE_COMPRESSED = 65280;

        /// MPQ_FILE_ENCRYPTED -> 0x00010000
        public const int MPQ_FILE_ENCRYPTED = 65536;

        /// MPQ_FILE_FIX_KEY -> 0x00020000
        public const int MPQ_FILE_FIX_KEY = 131072;

        /// MPQ_FILE_PATCH_FILE -> 0x00100000
        public const int MPQ_FILE_PATCH_FILE = 1048576;

        /// MPQ_FILE_SINGLE_UNIT -> 0x01000000
        public const int MPQ_FILE_SINGLE_UNIT = 16777216;

        /// MPQ_FILE_DELETE_MARKER -> 0x02000000
        public const int MPQ_FILE_DELETE_MARKER = 33554432;

        /// MPQ_FILE_SECTOR_CRC -> 0x04000000
        public const int MPQ_FILE_SECTOR_CRC = 67108864;

        /// MPQ_FILE_EXISTS -> 0x80000000
        public const int MPQ_FILE_EXISTS = -2147483648;

        /// MPQ_FILE_REPLACEEXISTING -> 0x80000000
        public const int MPQ_FILE_REPLACEEXISTING = -2147483648;

        /// MPQ_FILE_VALID_FLAGS -> (MPQ_FILE_IMPLODE       |                                    MPQ_FILE_COMPRESS      |                                    MPQ_FILE_ENCRYPTED     |                                    MPQ_FILE_FIX_KEY       |                                    MPQ_FILE_PATCH_FILE    |                                    MPQ_FILE_SINGLE_UNIT   |                                    MPQ_FILE_DELETE_MARKER |                                    MPQ_FILE_SECTOR_CRC    |                                    MPQ_FILE_EXISTS)
        public const int MPQ_FILE_VALID_FLAGS = (NativeConstants.MPQ_FILE_IMPLODE
                    | (NativeConstants.MPQ_FILE_COMPRESS
                    | (NativeConstants.MPQ_FILE_ENCRYPTED
                    | (NativeConstants.MPQ_FILE_FIX_KEY
                    | (NativeConstants.MPQ_FILE_PATCH_FILE
                    | (NativeConstants.MPQ_FILE_SINGLE_UNIT
                    | (NativeConstants.MPQ_FILE_DELETE_MARKER
                    | (NativeConstants.MPQ_FILE_SECTOR_CRC | NativeConstants.MPQ_FILE_EXISTS))))))));

        /// MPQ_COMPRESSION_HUFFMANN -> 0x01
        public const int MPQ_COMPRESSION_HUFFMANN = 1;

        /// MPQ_COMPRESSION_ZLIB -> 0x02
        public const int MPQ_COMPRESSION_ZLIB = 2;

        /// MPQ_COMPRESSION_PKWARE -> 0x08
        public const int MPQ_COMPRESSION_PKWARE = 8;

        /// MPQ_COMPRESSION_BZIP2 -> 0x10
        public const int MPQ_COMPRESSION_BZIP2 = 16;

        /// MPQ_COMPRESSION_SPARSE -> 0x20
        public const int MPQ_COMPRESSION_SPARSE = 32;

        /// MPQ_COMPRESSION_ADPCM_MONO -> 0x40
        public const int MPQ_COMPRESSION_ADPCM_MONO = 64;

        /// MPQ_COMPRESSION_ADPCM_STEREO -> 0x80
        public const int MPQ_COMPRESSION_ADPCM_STEREO = 128;

        /// MPQ_COMPRESSION_WAVE_MONO -> 0x40
        public const int MPQ_COMPRESSION_WAVE_MONO = 64;

        /// MPQ_COMPRESSION_WAVE_STEREO -> 0x80
        public const int MPQ_COMPRESSION_WAVE_STEREO = 128;

        /// MPQ_COMPRESSION_LZMA -> 0x12
        public const int MPQ_COMPRESSION_LZMA = 18;

        /// MPQ_WAVE_QUALITY_HIGH -> 0
        public const int MPQ_WAVE_QUALITY_HIGH = 0;

        /// MPQ_WAVE_QUALITY_MEDIUM -> 1
        public const int MPQ_WAVE_QUALITY_MEDIUM = 1;

        /// MPQ_WAVE_QUALITY_LOW -> 2
        public const int MPQ_WAVE_QUALITY_LOW = 2;

        /// SFILE_INFO_ARCHIVE_NAME -> 1
        public const int SFILE_INFO_ARCHIVE_NAME = 1;

        /// SFILE_INFO_ARCHIVE_SIZE -> 2
        public const int SFILE_INFO_ARCHIVE_SIZE = 2;

        /// SFILE_INFO_MAX_FILE_COUNT -> 3
        public const int SFILE_INFO_MAX_FILE_COUNT = 3;

        /// SFILE_INFO_HASH_TABLE_SIZE -> 4
        public const int SFILE_INFO_HASH_TABLE_SIZE = 4;

        /// SFILE_INFO_BLOCK_TABLE_SIZE -> 5
        public const int SFILE_INFO_BLOCK_TABLE_SIZE = 5;

        /// SFILE_INFO_SECTOR_SIZE -> 6
        public const int SFILE_INFO_SECTOR_SIZE = 6;

        /// SFILE_INFO_HASH_TABLE -> 7
        public const int SFILE_INFO_HASH_TABLE = 7;

        /// SFILE_INFO_BLOCK_TABLE -> 8
        public const int SFILE_INFO_BLOCK_TABLE = 8;

        /// SFILE_INFO_NUM_FILES -> 9
        public const int SFILE_INFO_NUM_FILES = 9;

        /// SFILE_INFO_STREAM_FLAGS -> 10
        public const int SFILE_INFO_STREAM_FLAGS = 10;

        /// SFILE_INFO_IS_READ_ONLY -> 11
        public const int SFILE_INFO_IS_READ_ONLY = 11;

        /// SFILE_INFO_HASH_INDEX -> 100
        public const int SFILE_INFO_HASH_INDEX = 100;

        /// SFILE_INFO_CODENAME1 -> 101
        public const int SFILE_INFO_CODENAME1 = 101;

        /// SFILE_INFO_CODENAME2 -> 102
        public const int SFILE_INFO_CODENAME2 = 102;

        /// SFILE_INFO_LOCALEID -> 103
        public const int SFILE_INFO_LOCALEID = 103;

        /// SFILE_INFO_BLOCKINDEX -> 104
        public const int SFILE_INFO_BLOCKINDEX = 104;

        /// SFILE_INFO_FILE_SIZE -> 105
        public const int SFILE_INFO_FILE_SIZE = 105;

        /// SFILE_INFO_COMPRESSED_SIZE -> 106
        public const int SFILE_INFO_COMPRESSED_SIZE = 106;

        /// SFILE_INFO_FLAGS -> 107
        public const int SFILE_INFO_FLAGS = 107;

        /// SFILE_INFO_POSITION -> 108
        public const int SFILE_INFO_POSITION = 108;

        /// SFILE_INFO_KEY -> 109
        public const int SFILE_INFO_KEY = 109;

        /// SFILE_INFO_KEY_UNFIXED -> 110
        public const int SFILE_INFO_KEY_UNFIXED = 110;

        /// SFILE_INFO_FILETIME -> 111
        public const int SFILE_INFO_FILETIME = 111;

        /// LISTFILE_NAME -> "(listfile)"
        public const string LISTFILE_NAME = "(listfile)";

        /// SIGNATURE_NAME -> "(signature)"
        public const string SIGNATURE_NAME = "(signature)";

        /// ATTRIBUTES_NAME -> "(attributes)"
        public const string ATTRIBUTES_NAME = "(attributes)";

        /// STORMLIB_VERSION -> 0x0801
        public const int STORMLIB_VERSION = 2049;

        /// STORMLIB_VERSION_STRING -> "8.01"
        public const string STORMLIB_VERSION_STRING = "8.01";

        /// MPQ_FORMAT_VERSION_1 -> 0
        public const int MPQ_FORMAT_VERSION_1 = 0;

        /// MPQ_FORMAT_VERSION_2 -> 1
        public const int MPQ_FORMAT_VERSION_2 = 1;

        /// MPQ_FORMAT_VERSION_3 -> 2
        public const int MPQ_FORMAT_VERSION_3 = 2;

        /// MPQ_FORMAT_VERSION_4 -> 3
        public const int MPQ_FORMAT_VERSION_4 = 3;

        /// MPQ_ATTRIBUTE_CRC32 -> 0x00000001
        public const int MPQ_ATTRIBUTE_CRC32 = 1;

        /// MPQ_ATTRIBUTE_FILETIME -> 0x00000002
        public const int MPQ_ATTRIBUTE_FILETIME = 2;

        /// MPQ_ATTRIBUTE_MD5 -> 0x00000004
        public const int MPQ_ATTRIBUTE_MD5 = 4;

        /// MPQ_ATTRIBUTE_ALL -> 0x00000007
        public const int MPQ_ATTRIBUTE_ALL = 7;

        /// MPQ_ATTRIBUTES_V1 -> 100
        public const int MPQ_ATTRIBUTES_V1 = 100;

        /// MPQ_OPEN_NO_LISTFILE -> 0x0010
        public const int MPQ_OPEN_NO_LISTFILE = 16;

        /// MPQ_OPEN_NO_ATTRIBUTES -> 0x0020
        public const int MPQ_OPEN_NO_ATTRIBUTES = 32;

        /// MPQ_OPEN_FORCE_MPQ_V1 -> 0x0040
        public const int MPQ_OPEN_FORCE_MPQ_V1 = 64;

        /// MPQ_OPEN_CHECK_SECTOR_CRC -> 0x0080
        public const int MPQ_OPEN_CHECK_SECTOR_CRC = 128;

        /// MPQ_OPEN_READ_ONLY -> 0x0100
        public const int MPQ_OPEN_READ_ONLY = 256;

        /// MPQ_OPEN_ENCRYPTED -> 0x0200
        public const int MPQ_OPEN_ENCRYPTED = 512;

        /// MPQ_CREATE_ATTRIBUTES -> 0x00000001
        public const int MPQ_CREATE_ATTRIBUTES = 1;

        /// MPQ_CREATE_NO_MPQ_CHECK -> 0x00000002
        public const int MPQ_CREATE_NO_MPQ_CHECK = 2;

        /// MPQ_CREATE_ARCHIVE_V1 -> 0x00000000
        public const int MPQ_CREATE_ARCHIVE_V1 = 0;

        /// MPQ_CREATE_ARCHIVE_V2 -> 0x00010000
        public const int MPQ_CREATE_ARCHIVE_V2 = 65536;

        /// MPQ_CREATE_ARCHIVE_V3 -> 0x00020000
        public const int MPQ_CREATE_ARCHIVE_V3 = 131072;

        /// MPQ_CREATE_ARCHIVE_V4 -> 0x00030000
        public const int MPQ_CREATE_ARCHIVE_V4 = 196608;

        /// MPQ_CREATE_ARCHIVE_VMASK -> 0x000F0000
        public const int MPQ_CREATE_ARCHIVE_VMASK = 983040;

        /// SFILE_VERIFY_SECTOR_CRC -> 0x0001
        public const int SFILE_VERIFY_SECTOR_CRC = 1;

        /// SFILE_VERIFY_FILE_CRC -> 0x0002
        public const int SFILE_VERIFY_FILE_CRC = 2;

        /// SFILE_VERIFY_FILE_MD5 -> 0x0004
        public const int SFILE_VERIFY_FILE_MD5 = 4;

        /// SFILE_VERIFY_RAW_MD5 -> 0x0008
        public const int SFILE_VERIFY_RAW_MD5 = 8;

        /// SFILE_VERIFY_ALL -> 0x000F
        public const int SFILE_VERIFY_ALL = 15;

        /// VERIFY_OPEN_ERROR -> 0x0001
        public const int VERIFY_OPEN_ERROR = 1;

        /// VERIFY_READ_ERROR -> 0x0002
        public const int VERIFY_READ_ERROR = 2;

        /// VERIFY_FILE_HAS_SECTOR_CRC -> 0x0004
        public const int VERIFY_FILE_HAS_SECTOR_CRC = 4;

        /// VERIFY_FILE_SECTOR_CRC_ERROR -> 0x0008
        public const int VERIFY_FILE_SECTOR_CRC_ERROR = 8;

        /// VERIFY_FILE_HAS_CHECKSUM -> 0x0010
        public const int VERIFY_FILE_HAS_CHECKSUM = 16;

        /// VERIFY_FILE_CHECKSUM_ERROR -> 0x0020
        public const int VERIFY_FILE_CHECKSUM_ERROR = 32;

        /// VERIFY_FILE_HAS_MD5 -> 0x0040
        public const int VERIFY_FILE_HAS_MD5 = 64;

        /// VERIFY_FILE_MD5_ERROR -> 0x0080
        public const int VERIFY_FILE_MD5_ERROR = 128;

        /// VERIFY_FILE_HAS_RAW_MD5 -> 0x0100
        public const int VERIFY_FILE_HAS_RAW_MD5 = 256;

        /// VERIFY_FILE_RAW_MD5_ERROR -> 0x0200
        public const int VERIFY_FILE_RAW_MD5_ERROR = 512;

        /// SFILE_VERIFY_MPQ_HEADER -> 0x0001
        public const int SFILE_VERIFY_MPQ_HEADER = 1;

        /// SFILE_VERIFY_HET_TABLE -> 0x0002
        public const int SFILE_VERIFY_HET_TABLE = 2;

        /// SFILE_VERIFY_BET_TABLE -> 0x0003
        public const int SFILE_VERIFY_BET_TABLE = 3;

        /// SFILE_VERIFY_HASH_TABLE -> 0x0004
        public const int SFILE_VERIFY_HASH_TABLE = 4;

        /// SFILE_VERIFY_BLOCK_TABLE -> 0x0005
        public const int SFILE_VERIFY_BLOCK_TABLE = 5;

        /// SFILE_VERIFY_HIBLOCK_TABLE -> 0x0006
        public const int SFILE_VERIFY_HIBLOCK_TABLE = 6;

        /// SFILE_VERIFY_FILE -> 0x0007
        public const int SFILE_VERIFY_FILE = 7;

        /// ERROR_NO_SIGNATURE -> 0
        public const int ERROR_NO_SIGNATURE = 0;

        /// ERROR_VERIFY_FAILED -> 1
        public const int ERROR_VERIFY_FAILED = 1;

        /// ERROR_WEAK_SIGNATURE_OK -> 2
        public const int ERROR_WEAK_SIGNATURE_OK = 2;

        /// ERROR_WEAK_SIGNATURE_ERROR -> 3
        public const int ERROR_WEAK_SIGNATURE_ERROR = 3;

        /// ERROR_STRONG_SIGNATURE_OK -> 4
        public const int ERROR_STRONG_SIGNATURE_OK = 4;

        /// ERROR_STRONG_SIGNATURE_ERROR -> 5
        public const int ERROR_STRONG_SIGNATURE_ERROR = 5;

        /// MD5_DIGEST_SIZE -> 0x10
        public const int MD5_DIGEST_SIZE = 16;

        /// SHA1_DIGEST_SIZE -> 0x14
        public const int SHA1_DIGEST_SIZE = 20;

        /// CCB_CHECKING_FILES -> 1
        public const int CCB_CHECKING_FILES = 1;

        /// CCB_CHECKING_HASH_TABLE -> 2
        public const int CCB_CHECKING_HASH_TABLE = 2;

        /// CCB_COPYING_NON_MPQ_DATA -> 3
        public const int CCB_COPYING_NON_MPQ_DATA = 3;

        /// CCB_COMPACTING_FILES -> 4
        public const int CCB_COMPACTING_FILES = 4;

        /// CCB_CLOSING_ARCHIVE -> 5
        public const int CCB_CLOSING_ARCHIVE = 5;

        /// MPQ_HEADER_SIZE_V1 -> 0x20
        public const int MPQ_HEADER_SIZE_V1 = 32;

        /// MPQ_HEADER_SIZE_V2 -> 0x2C
        public const int MPQ_HEADER_SIZE_V2 = 44;

        /// MPQ_HEADER_SIZE_V3 -> 0x44
        public const int MPQ_HEADER_SIZE_V3 = 68;

        /// MPQ_HEADER_SIZE_V4 -> 0xD0
        public const int MPQ_HEADER_SIZE_V4 = 208;

        /// SIZE_OF_XFRM_HEADER -> 0x0C
        public const int SIZE_OF_XFRM_HEADER = 12;

        /// SFILE_FLAG_ALLOW_WRITE_SHARE -> 0x00000001
        public const int SFILE_FLAG_ALLOW_WRITE_SHARE = 1;
    }
}
