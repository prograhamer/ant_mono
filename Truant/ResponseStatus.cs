namespace Truant
{
	public enum ResponseStatus : byte
	{
		NO_ERROR                                   = 0x00,
		
		EVENT_RX_SEARCH_TIMEOUT                    = 0x01,
		EVENT_RX_FAIL                              = 0x02,
		EVENT_TX                                   = 0x03,
		EVENT_TRANSFER_RX_FAILED                   = 0x04,
		EVENT_TRANSFER_TX_COMPLETED                = 0x05,
		EVENT_TRANSFER_TX_FAILED                   = 0x06,
		EVENT_CHANNEL_CLOSED                       = 0x07,
		EVENT_RX_FAIL_GO_TO_SEARCH                 = 0x08,
		EVENT_CHANNEL_COLLISION                    = 0x09,
		EVENT_TRANSFER_TX_START                    = 0x0A,           // a pending transmit transfer has begun
		
		EVENT_CHANNEL_ACTIVE                       = 0x0F,
		
		EVENT_TRANSFER_TX_NEXT_MESSAGE             = 0x11,           // only enabled in FIT1
		
		CHANNEL_IN_WRONG_STATE                     = 0x15,           // returned on attempt to perform an action from the wrong channel state
		CHANNEL_NOT_OPENED                         = 0x16,           // returned on attempt to communicate on a channel that is not open
		CHANNEL_ID_NOT_SET                         = 0x18,           // returned on attempt to open a channel without setting the channel ID
		CLOSE_ALL_CHANNELS                         = 0x19,           // returned when attempting to start scanning mode, when channels are still open
		
		TRANSFER_IN_PROGRESS                       = 0x1F,           // returned on attempt to communicate on a channel with a TX transfer in progress
		TRANSFER_SEQUENCE_NUMBER_ERROR             = 0x20,           // returned when sequence number is out of order on a Burst transfer
		TRANSFER_IN_ERROR                          = 0x21,
		TRANSFER_BUSY                              = 0x22,
		
		INVALID_MESSAGE_CRC                        = 0x26,           // returned if there is a framing error on an incomming message
		MESSAGE_SIZE_EXCEEDS_LIMIT                 = 0x27,           // returned if a data message is provided that is too large
		INVALID_MESSAGE                            = 0x28,           // returned when the message has an invalid parameter
		INVALID_NETWORK_NUMBER                     = 0x29,           // returned when an invalid network number is provided
		INVALID_LIST_ID                            = 0x30,           // returned when the provided list ID or size exceeds the limit
		INVALID_SCAN_TX_CHANNEL                    = 0x31,           // returned when attempting to transmit on channel 0 when in scan mode
		INVALID_PARAMETER_PROVIDED                 = 0x33,           // returned when an invalid parameter is specified in a configuration message
		
		EVENT_SERIAL_QUE_OVERFLOW                  = 0x34,
		EVENT_QUE_OVERFLOW                         = 0x35,           // ANT event que has overflowed and lost 1 or more events
		
		EVENT_CLK_ERROR                            = 0x36,           // debug event for XOSC16M on LE1
		EVENT_STATE_OVERRUN                        = 0x37,
		
		
		SCRIPT_FULL_ERROR                          = 0x40,           // error writing to script, memory is full
		SCRIPT_WRITE_ERROR                         = 0x41,           // error writing to script, bytes not written correctly
		SCRIPT_INVALID_PAGE_ERROR                  = 0x42,           // error accessing script page
		SCRIPT_LOCKED_ERROR                        = 0x43,           // the scripts are locked and can't be dumped
		
		NO_RESPONSE_MESSAGE                        = 0x50,           // returned to the Command_SerialMessageProcess function, so no reply message is generated
		RETURN_TO_MFG                              = 0x51,           // default return to any mesg when the module determines that the mfg procedure has not been fully completed
		
		FIT_ACTIVE_SEARCH_TIMEOUT                  = 0x60,           // Fit1 only event added for timeout of the pairing state after the Fit module becomes active
		FIT_WATCH_PAIR                             = 0x61,           // Fit1 only
		FIT_WATCH_UNPAIR                           = 0x62,           // Fit1 only
		
		USB_STRING_WRITE_FAIL                      = 0x70,
		
		// Internal only events below this point
		INTERNAL_ONLY_EVENTS                       = 0x80,
		EVENT_RX                                   = 0x80,           // INTERNAL: Event for a receive message
		EVENT_NEW_CHANNEL                          = 0x81,           // INTERNAL: EVENT for a new active channel
		EVENT_PASS_THRU                            = 0x82,           // INTERNAL: Event to allow an upper stack events to pass through lower stacks
		
		EVENT_BLOCKED                              = 0xFF,           // INTERNAL: Event to replace any event we do not wish to go out, will also zero the size of the Tx message

		// PC Application Event Codes
		//NOTE: These events are not generated by the embedded ANT module
		EVENT_RX_BROADCAST                         = 0x9A,           // returned when module receives broadcast data
		EVENT_RX_ACKNOWLEDGED                      = 0x9B,           // returned when module receives acknowledged data
		EVENT_RX_BURST_PACKET                      = 0x9C,           // returned when module receives burst data
		
		EVENT_RX_EXT_BROADCAST                     = 0x9D,           // returned when module receives broadcast data
		EVENT_RX_EXT_ACKNOWLEDGED                  = 0x9E,           // returned when module receives acknowledged data
		EVENT_RX_EXT_BURST_PACKET                  = 0x9F,           // returned when module receives burst data
		
		EVENT_RX_RSSI_BROADCAST                    = 0xA0,           // returned when module receives broadcast data
		EVENT_RX_RSSI_ACKNOWLEDGED                 = 0xA1,           // returned when module receives acknowledged data
		EVENT_RX_RSSI_BURST_PACKET                 = 0xA2,           // returned when module receives burst data
		
		EVENT_RX_FLAG_BROADCAST                    = 0xA3,          // returned when module receives broadcast data with flag attached
		EVENT_RX_FLAG_ACKNOWLEDGED                 = 0xA4,          // returned when module receives acknowledged data with flag attached
		EVENT_RX_FLAG_BURST_PACKET                 = 0xA5,          // returned when module receives burst data with flag attached
	}
}

