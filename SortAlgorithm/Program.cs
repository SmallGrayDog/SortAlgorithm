using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

lua scripts
-- --二分查找
-- function UI_WeatherMain:Binary_Search(_CurDate)
-- 	if _CurDate ~= 0000 then 
-- 		local _CureDateNum = tonumber(_CurDate)
-- 		local _start = 1
-- 		local _end = #TB_WEATHER_CONFIG
-- 		while _start <= _end do 
-- 			local _mid = math.floor( (_start + _end) / 2)
-- 			if _CureDateNum > TB_WEATHER_CONFIG[_mid].Date then 
-- 			_start = _mid + 1 
-- 			elseif _CureDateNum < TB_WEATHER_CONFIG[_mid].Date then 
-- 				_end = _mid - 1 
-- 			else 
-- 				return  TB_WEATHER_CONFIG[_mid]
-- 			end
-- 		end
-- 		return nil
-- 	end
-- 	return nil
-- end
