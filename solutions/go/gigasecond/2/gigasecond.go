package gigasecond

import (
	"time"
)

// AddGigasecond takes t of type time.Time (a UTC timestamp),
// adds a gigasecond (1e9 seconds) to it,
// converts it back into a UTC timestamp
// returns this new timestamp
func AddGigasecond(t time.Time) time.Time {
	return time.Unix(t.Unix()+1e9, 0)
}