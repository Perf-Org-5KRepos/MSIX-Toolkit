﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml;

namespace AppInstallerFileBuilder.Model
{
    [DataContract(Name = "Package")]
    class Package
    {
        [DataMember(Name = "Uri")]
        private String _filePath;

        [DataMember(Name = "PackageType")]
        private PackageType _packageType;

        [DataMember(Name = "Version")]
        private String _version;

        [DataMember(Name = "Publisher")]
        private String _publisher;

        [DataMember(Name = "Name")]
        private String _name;

        [DataMember(Name = "ProcessorArchitecture")]
        private String _processorArchitecture;

        public Package()
        {
            _filePath = "";
            _version = "";
            _packageType = PackageType.MSIX;
            _publisher = "";
            _name = "";
            _processorArchitecture = "";
        }

        public Package(String filePath, String version, String publisher, String name, PackageType packageType, String processorArchitecture)
        {
            _filePath = filePath;
            _version = version;
            _publisher = publisher;
            _packageType = packageType;
            _name = name;
            _processorArchitecture = processorArchitecture;
        }

        public String FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
            }
        }

        public String Version
        {
            get { return _version; }
            set
            {
                _version = value;
            }
        }

        public String Publisher
        {
            get { return _publisher; }
            set
            {
                _publisher = value;
            }
        }

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public PackageType PackageType
        {
            get { return _packageType; }
            set
            {
                _packageType = value;
            }
        }

        public String ProcessorArchitecture
        {
            get { return _processorArchitecture; }
            set
            {
                _processorArchitecture = value;
            }
        }
    }
}
