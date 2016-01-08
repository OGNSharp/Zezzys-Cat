using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Vayne Hunter Reborn for Korean Asuna x OGN
    Be a Spacebar PRO
        Be a Challenger
            Defeat Faker
                Win the LOL World Championship
                    Done~! That's what i want it ☆
*/
namespace VayneHunter_Reborn.External.Translation.Languages
{
    class Korean : IVHRLanguage
    {
        public string GetName()
        {
            return "Korean";
        }

        public Dictionary<string, string> GetTranslations()
        {
            var translations = new Dictionary<string, string>
            {
                {"dz191.vhr.combo.r.minenemies", "R 사용할때 최소 적의 수"},
                {"dz191.vhr.combo.q.2wstacks", "W 2스택인 적에게만 구르기 사용"},
                {"dz191.vhr.mixed.q.2wstacks", "W 2스택인 적에게만 구르기 사용"},
                {"dz191.vhr.mixed.ethird", "선고로 W 3스택 견제"},
                {"dz191.vhr.farm.condemnjungle", "정글몹에게 선고 사용"},
                {"dz191.vhr.farm.qjungle", "정글몹위치 반대로 구르기 사용 "},
                {"dz191.vhr.misc.condemn.qlogic", "구르기 로직"},
                {"dz191.vhr.mixed.mirinQ", "벽구르기로 평타캔슬 (Mirin 모드)"},
                {"dz191.vhr.misc.tumble.smartq", "가능할때 구르기 + 선고 사용"},
                {"dz191.vhr.misc.tumble.noaastealthex", "은신중 평타 차단"},
                {"dz191.vhr.misc.tumble.noqenemies", "앞구르기 차단"},
                {"dz191.vhr.misc.tumble.dynamicqsafety", "거리 유지용 구르기 사용"},
                {"dz191.vhr.misc.tumble.qspam", "구르기 안전성 무시"},
                {"dz191.vhr.misc.tumble.qinrange", "Q 킬스틸"},
                {"dz191.vhr.misc.condemn.condemnmethod", "선고 방식"},
                {"dz191.vhr.misc.condemn.pushdistance", "선고 밀기 거리"},
                {"dz191.vhr.misc.condemn.accuracy", "선고정확도 (Revolution 만 지원)"},
                {"dz191.vhr.misc.condemn.enextauto", "자동 공격후 선고 사용"},
                {"dz191.vhr.misc.condemn.onlystuncurrent", "선택된 목표만 스턴"},
                {"dz191.vhr.misc.condemn.autoe", "자동 선고"},
                {"dz191.vhr.misc.condemn.eks", "스마트 선고 킬스틸"},
                {"dz191.vhr.misc.condemn.noeaa", "X번의 평타로 적을 죽일수 있으면 선고 차단"},
                {"dz191.vhr.misc.condemn.trinketbush", "부쉬로 선고후 망원렌즈 사용"},
                {"dz191.vhr.misc.condemn.lowlifepeel", "자신의 체력이 낮으면 적에게 선고 사용"},
                {"dz191.vhr.misc.condemn.noeturret", "적 타워에 선고 사용안함"},
                {"dz191.vhr.misc.general.antigp", "안티 갭클로저"},
                {"dz191.vhr.misc.general.interrupt", "방해"},
                {"dz191.vhr.misc.general.antigpdelay", "안티 갭클로저 딜레이 (ms)"},
                {"dz191.vhr.misc.general.specialfocus", "W 2스택인 적에게 집중"},
                {"dz191.vhr.misc.general.reveal", "(핑크와드,렌즈)로 은신한적 감지"},
                {"dz191.vhr.misc.general.disablemovement", "오브워커 움직임 차단"},
                {"dz191.vhr.misc.general.disableattk", "오브워커 공격 차단"},
                {"dz191.vhr.draw.spots", "위치 표시"},
                {"dz191.vhr.draw.range", "적 평타 사거리 표시"},
                {"dz191.vhr.draw.qpos", "Reborn 구르기 위치 표시 (디버그)"},
                {"dz191.vhr.activator.onkey", "엑티베이터 키"},
                {"dz191.vhr.activator.always", "항상 사용"},
                {"dz191.vhr.activator.spells.barrier.onhealth", "내 체력 < (%)"},
                {"dz191.vhr.activator.spells.heal.onhealth", "내 체력 < (%)"},
                {" ", " "},

            };

            return translations;
        }
    }
}
