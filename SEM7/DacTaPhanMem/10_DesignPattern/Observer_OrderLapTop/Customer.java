public class Customer implements Observer {
    private String name;
    public Customer(String name) {
        this.name = name;
    }
    @Override
    public void update(String message) {
        System.out.println("Notification to " + name + ": " + message);
    }
}
