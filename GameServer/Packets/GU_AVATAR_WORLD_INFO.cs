﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseLib.Packets;
using BaseLib.Structs;

namespace GameServer.Packets
{
    class GU_AVATAR_WORLD_INFO : Packet
    {
        GU_AVATAR_WORLD_INFO()
        {
            //Default initialization
            sVECTOR3 vCurLoc = new sVECTOR3(0, 0, 0);
            sVECTOR3 vCurDir = new sVECTOR3(0, 0, 0);
            sGAME_RULE_INFO worldInfo;
            Byte            byDojoCount;
            
            sDBO_DOJO_BRIEF sDojoData[] = new sDBO_DOJO_BRIEF[DBOCommon.DBO_DOJO_IN_WORLD_MAX];

        }


    }
}

/*
BEGIN_PROTOCOL(GU_AVATAR_WORLD_INFO)
	sVECTOR3		vCurLoc;
	sVECTOR3		vCurDir;
	sWORLD_INFO		worldInfo;
	nsigned char - BYTE			byDojoCount;
	sDBO_DOJO_BRIEF sDojoData[DBO_MAX_COUNT_DOJO_IN_WORLD];
END_PROTOCOL()

struct sWORLD_INFO
{
	// World Base Info
	unsigned int - WORLDID			worldID;	// żůµĺ ŔÎ˝şĹĎ˝ş ÇÚµé
	unsigned int - TBLIDX			tblidx;		// żůµĺ Ĺ×ŔĚşí ŔÎµ¦˝ş

	// World Game Info
	HOBJECT			hTriggerObjectOffset; // Ć®¸®°Ĺ żŔşęÁ§Ć® ˝ĂŔŰ ÇÚµé°Ş (Ć®¸®°Ĺ żŔşęÁ§Ć® Ĺ×ŔĚşíŔÇ żŔşęÁ§Ć®¸¦ »ýĽş˝Ă Ĺ×ŔĚşí ąřČŁ + ˝ĂŔŰ ÇÚµéąřČŁ·Î »ýĽşÇŇ °Í )

	// World Rule Info
	sGAME_RULE_INFO	sRuleInfo;
};
struct sVECTOR3
{
	float x;
	float y;
	float z;
};

    struct sVECTOR3
{
	float x;
	float y;
	float z;
};

*/
