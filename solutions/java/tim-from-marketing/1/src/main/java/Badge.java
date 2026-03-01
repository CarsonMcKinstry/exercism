class Badge {
    public String print(Integer id, String name, String department) {
        StringBuilder badge = new StringBuilder();

        if (id != null) {
            badge.append(String.format("[%d] - ", id));
        }

        badge.append(
                String.format(
                        "%s - %s",
                        name,
                        department == null ? "OWNER" : department.toUpperCase()));

        return badge.toString();
    }
}
