/*
* Copyright (C) 2012 Mamadou Diop.
*
* Contact: Mamadou Diop <diopmamadou(at)doubango(dot)org>
*	
* This file is part of Open Source Doubango Framework.
*
* DOUBANGO is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*	
* DOUBANGO is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*	
* You should have received a copy of the GNU General Public License
* along with DOUBANGO.
*
*/

/**@file thttp_header_Sec_WebSocket_Accept.c
 * @brief WebSocket "Sec-WebSocket-Accept" header.
 *
 * @author Mamadou Diop <diopmamadou(at)doubango(dor)org>
 *
 */
#include "tinyhttp/headers/thttp_header_Sec_WebSocket_Accept.h"

#include "tsk_debug.h"

#include <string.h>

%%{
	machine thttp_machine_parser_header_Sec_WebSocket_Accept;

	# Includes
	include thttp_machine_utils "./ragel/thttp_machine_utils.rl";
	include thttp_machine_ws "./ragel/thttp_machine_ws.rl";

	action tag { tag_start = p; }
	action eob { }

	action parse_key{
		TSK_PARSER_SET_STRING(hdr_Sec_WebSocket_Accept->value);
	}

	# Entry point
	main := "Sec-WebSocket-Accept"i SP* HCOLON SP*<: Sec_WebSocket_Accept>tag %parse_key :>CRLF @eob;
}%%

thttp_header_Sec_WebSocket_Accept_t* thttp_header_Sec_WebSocket_Accept_create(const char* value)
{
	return tsk_object_new(THTTP_HEADER_SEC_WEBSOCKET_ACCEPT_VA_ARGS(value));
}

thttp_header_Sec_WebSocket_Accept_t* thttp_header_Sec_WebSocket_Accept_create_null()
{ 
	return thttp_header_Sec_WebSocket_Accept_create(tsk_null);
}


int thttp_header_Sec_WebSocket_Accept_tostring(const thttp_header_t* header, tsk_buffer_t* output)
{
	if(header){
		const thttp_header_Sec_WebSocket_Accept_t *Sec_WebSocket_Accept = (const thttp_header_Sec_WebSocket_Accept_t*)header;
		if(Sec_WebSocket_Accept->value){
			return tsk_buffer_append(output, Sec_WebSocket_Accept->value, tsk_strlen(Sec_WebSocket_Accept->value));
		}
		return 0;
	}

	return -1;
}

thttp_header_Sec_WebSocket_Accept_t *thttp_header_Sec_WebSocket_Accept_parse(const char *data, tsk_size_t size)
{
	int cs = 0;
	const char *p = data;
	const char *pe = p + size;
	const char *eof = pe;
	thttp_header_Sec_WebSocket_Accept_t *hdr_Sec_WebSocket_Accept = thttp_header_Sec_WebSocket_Accept_create_null();
	
	const char *tag_start;

	%%write data;
	(void)(eof);
	(void)(thttp_machine_parser_header_Sec_WebSocket_Accept_first_final);
	(void)(thttp_machine_parser_header_Sec_WebSocket_Accept_error);
	(void)(thttp_machine_parser_header_Sec_WebSocket_Accept_en_main);
	%%write init;
	%%write exec;
	
	if( cs < %%{ write first_final; }%% ){
		TSK_DEBUG_ERROR("Failed to parse Sec-WebSocket-Accept header.");
		TSK_OBJECT_SAFE_FREE(hdr_Sec_WebSocket_Accept);
	}
	
	return hdr_Sec_WebSocket_Accept;
}







//========================================================
//	Sec_WebSocket_Accept header object definition
//

static tsk_object_t* thttp_header_Sec_WebSocket_Accept_ctor(tsk_object_t *self, va_list * app)
{
	thttp_header_Sec_WebSocket_Accept_t *Sec_WebSocket_Accept = self;
	if(Sec_WebSocket_Accept){
		THTTP_HEADER(Sec_WebSocket_Accept)->type = thttp_htype_Sec_WebSocket_Accept;
		THTTP_HEADER(Sec_WebSocket_Accept)->tostring = thttp_header_Sec_WebSocket_Accept_tostring;

		Sec_WebSocket_Accept->value = tsk_strdup(va_arg(*app, const char*));
	}
	else{
		TSK_DEBUG_ERROR("Failed to create new Sec-WebSocket-Accept header.");
	}
	return self;
}

static tsk_object_t* thttp_header_Sec_WebSocket_Accept_dtor(tsk_object_t *self)
{
	thttp_header_Sec_WebSocket_Accept_t *Sec_WebSocket_Accept = self;
	if(Sec_WebSocket_Accept){
		TSK_FREE(Sec_WebSocket_Accept->value);
		TSK_OBJECT_SAFE_FREE(THTTP_HEADER_PARAMS(Sec_WebSocket_Accept));
	}
	else{
		TSK_DEBUG_ERROR("Null Sec_WebSocket_Accept header.");
	}

	return self;
}

static const tsk_object_def_t thttp_header_Sec_WebSocket_Accept_def_s = 
{
	sizeof(thttp_header_Sec_WebSocket_Accept_t),
	thttp_header_Sec_WebSocket_Accept_ctor,
	thttp_header_Sec_WebSocket_Accept_dtor,
	tsk_null
};
const tsk_object_def_t *thttp_header_Sec_WebSocket_Accept_def_t = &thttp_header_Sec_WebSocket_Accept_def_s;
