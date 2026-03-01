import java.time.LocalDateTime
import java.time.LocalDate
import java.time.ZoneOffset
import java.time.Instant

class Gigasecond (val moment: LocalDateTime) {

    constructor(momentAsLocalDate: LocalDate) : this(momentAsLocalDate.atStartOfDay())

    val date: LocalDateTime
        get() {
            var seconds = moment.toEpochSecond(ZoneOffset.UTC)
            
            seconds += 1000000000

            return LocalDateTime.ofInstant(Instant.ofEpochSecond(seconds), ZoneOffset.UTC)
        }
}
