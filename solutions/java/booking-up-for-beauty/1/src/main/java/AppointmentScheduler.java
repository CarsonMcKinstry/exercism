import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.Month;
import java.time.format.DateTimeFormatter;

class AppointmentScheduler {
    public LocalDateTime schedule(String appointmentDateDescription) {
        DateTimeFormatter parser = DateTimeFormatter.ofPattern("MM/dd/yyyy HH:mm:ss");

        LocalDateTime date = LocalDateTime.parse(appointmentDateDescription, parser);

        return date;
    }

    public boolean hasPassed(LocalDateTime appointmentDate) {
        return appointmentDate.isBefore(LocalDateTime.now());
    }

    public boolean isAfternoonAppointment(LocalDateTime appointmentDate) {
        LocalTime appointmentTime = appointmentDate.toLocalTime();
        LocalTime startTime = LocalTime.parse("12:00:00");
        LocalTime endTime = LocalTime.parse("18:00:00");

        return appointmentTime.isBefore(endTime)
                && (appointmentTime.equals(startTime) || appointmentTime.isAfter(startTime));
    }

    public String getDescription(LocalDateTime appointmentDate) {
        String dayOfWeek = switch (appointmentDate.getDayOfWeek()) {
            case MONDAY -> "Monday";
            case TUESDAY -> "Tuesday";
            case WEDNESDAY -> "Wednesday";
            case THURSDAY -> "Thursday";
            case FRIDAY -> "Friday";
            case SATURDAY -> "Saturday";
            case SUNDAY -> "Sunday";

        };
        DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("MMMM d, uuuu");
        DateTimeFormatter timeFormatter = DateTimeFormatter.ofPattern("h:mm a");

        return String.format("You have an appointment on %s, %s, at %s.", dayOfWeek,
                dateFormatter.format(appointmentDate), timeFormatter.format(appointmentDate));
    }

    public LocalDate getAnniversaryDate() {
        return LocalDate.of(LocalDate.now().getYear(), Month.SEPTEMBER, 15);
    }
}
