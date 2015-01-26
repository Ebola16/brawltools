﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrawlLib.SSBBTypes;
using System.ComponentModel;
using System.IO;
using BrawlLib.IO;
using BrawlLib.Wii.Animations;
using BrawlLib.SSBB.ResourceNodes;
using BrawlLib.OpenGL;
using Ikarus;
using Ikarus.MovesetFile;

namespace Ikarus.MovesetBuilder
{
    public unsafe class DataCommonBuilder : BuilderBase
    {
        //---Notes--- (these may or may not actually matter - follow just to be safe)
        // - Subroutines are written right before the first script are called by
        // - Children are written before their parent

        //---General order of dataCommon---
        //Unknown23 Parameters
        //Unknown7's Children's Entries
        //Params8
        //Params10
        //Params16
        //Params18
        //Global IC-Basics // Unknown23 Offset
        //IC-Basics // Params24 Value
        //Params12
        //Params13
        //Params14
        //Params15
        //SSE Global IC-Basics
        //SSE IC-Basics
        //Flash Overlay Actions
        //patternPowerMul parameters
        //Flash Overlay Action Offsets
        //Screen Tint Actions
        //Screen Tint Action Offsets
        //Unknown22 entries
        //Entry/Exit actions alternating
        //Unknown7 Data entries
        //Unknown11
        //Leg bones
        //Unknown22 header
        //patternPowerMul header
        //patternPowerMul events  
        //Sections data
        //dataCommon header
        
        DataCommonSection _dataCommon;
        public DataCommonBuilder(DataCommonSection dataCommon) { _dataCommon = dataCommon; }

        public override int CalcSize()
        {
            _size = sizeof(CommonHeader);

            return _size;
        }

        public override void Build(VoidPtr address)
        {

        }
    }
}