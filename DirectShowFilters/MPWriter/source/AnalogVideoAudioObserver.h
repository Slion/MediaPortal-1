/* 
 *	Copyright (C) 2006-2008 Team MediaPortal
 *	http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */
#pragma once

// {F94D89B5-C888-4da1-9782-15C1C0CBFE4D}
DEFINE_GUID(IID_IAnalogVideoAudioObserver, 0xf94d89b5, 0xc888, 0x4da1, 0x97, 0x82, 0x15, 0xc1, 0xc0, 0xcb, 0xfe, 0x4d);


DECLARE_INTERFACE_(IAnalogVideoAudioObserver, IUnknown)
{
	STDMETHOD(OnNotify)(THIS_ int pidType)PURE;
};

enum PidType
{
  Video=0,
  Audio=1,
  Other=2
};




