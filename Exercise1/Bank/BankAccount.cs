import java.awt.EventQueue;


import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.BorderLayout;
import java.awt.CardLayout;
import javax.swing.JSplitPane;
import java.awt.event.ActionListener;
import java.util.LinkedList;
import java.awt.event.ActionEvent;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.JLayeredPane;
import javax.swing.JLabel;
import java.util.*;
import javax.swing.JTable;
import javax.swing.ListSelectionModel;
import javax.swing.table.DefaultTableModel; 

public class GraphicalUserInterface {

	private JFrame frame;
	private JTextField firstNameTextField;
	private JTextField lastNameTextField;
	private JTextField ageTextField;
	private JTextField emailTextField;
	private JTextField salaryTextField;
	private JTextField countryTextField;
	private JTextField cityTextField;
	private JTextField streetTextField;
	private JTable table;
	private JTextField textField;
	
	JPanel showManagersPanel;
	
	public int coutManager = 0;
    
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					GraphicalUserInterface window = new GraphicalUserInterface();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public GraphicalUserInterface() {
		
		showManagersPanel = new JPanel();
		initialize();
	}
	
	private void ManagerPanel() {
	
	}
	
	private void OpenPanel(JLayeredPane layeredPane,JPanel panel) {
		layeredPane.removeAll();
		layeredPane.add(panel);
		layeredPane.repaint();
		layeredPane.revalidate();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		
		frame = new JFrame();
		frame.getContentPane().setEnabled(false);
		frame.getContentPane().setLayout(null);
		
		LinkedList<Manager> managers = new LinkedList<Manager>(); 
		
		
		
		
		JLayeredPane layeredPane = new JLayeredPane();
		layeredPane.setBounds(366, 13, 741, 531);
		frame.getContentPane().add(layeredPane);
		layeredPane.setLayout(new CardLayout(0, 0));
		
		JPanel welcomePanel = new JPanel();
		layeredPane.add(welcomePanel, "name_671430906635100");
		welcomePanel.setLayout(null);
		
		
		
		
		
		
		JPanel managerPanel = new JPanel();
		layeredPane.add(managerPanel, "name_671604646307100");
		managerPanel.setLayout(null);
		
textField = new JTextField();
		
		textField.setBounds(454, 461, 39, 34);
		managerPanel.add(textField);
		textField.setColumns(10);
		
		
		JLabel firstName = new JLabel("First Name");
		firstName.setBounds(12, 0, 114, 34);
		managerPanel.add(firstName);
		
		JLabel lastName = new JLabel("Last Name");
		lastName.setBounds(12, 41, 114, 34);
		managerPanel.add(lastName);
		
		JLabel age = new JLabel("Age");
		age.setBounds(12, 88, 114, 34);
		managerPanel.add(age);
		
		JLabel email = new JLabel("Email");
		email.setBounds(12, 149, 114, 34);
		managerPanel.add(email);
		
		JLabel salary = new JLabel("Salary");
		salary.setBounds(12, 211, 114, 34);
		managerPanel.add(salary);
		
		JLabel country = new JLabel("Country");
		country.setBounds(12, 269, 114, 34);
		managerPanel.add(country);
		
		JLabel city = new JLabel("City");
		city.setBounds(12, 316, 114, 34);
		managerPanel.add(city);
		
		JLabel street = new JLabel("Street");
		street.setBounds(12, 382, 114, 34);
		managerPanel.add(street);
		
		firstNameTextField = new JTextField();
		firstNameTextField.setBounds(105, 6, 165, 22);
		managerPanel.add(firstNameTextField);
		firstNameTextField.setColumns(10);
		
		lastNameTextField = new JTextField();
		lastNameTextField.setColumns(10);
		lastNameTextField.setBounds(105, 47, 165, 22);
		managerPanel.add(lastNameTextField);
		
		ageTextField = new JTextField();
		ageTextField.setColumns(10);
		ageTextField.setBounds(105, 94, 165, 22);
		managerPanel.add(ageTextField);
		
		emailTextField = new JTextField();
		emailTextField.setColumns(10);
		emailTextField.setBounds(105, 155, 165, 22);
		managerPanel.add(emailTextField);
		
		salaryTextField = new JTextField();
		salaryTextField.setColumns(10);
		salaryTextField.setBounds(105, 217, 165, 22);
		managerPanel.add(salaryTextField);
		
		countryTextField = new JTextField();
		countryTextField.setColumns(10);
		countryTextField.setBounds(105, 275, 165, 22);
		managerPanel.add(countryTextField);
		
		cityTextField = new JTextField();
		cityTextField.setColumns(10);
		cityTextField.setBounds(105, 322, 165, 22);
		managerPanel.add(cityTextField);
		
		streetTextField = new JTextField();
		streetTextField.setColumns(10);
		streetTextField.setBounds(105, 388, 165, 22);
		managerPanel.add(streetTextField);
		
		int countManagers = managers.size();
		String convertedCountManagers = Integer.toString(countManagers);
		textField.setText(convertedCountManagers);
		
		JButton addManagerBtn = new JButton("Add");
		addManagerBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				String firstName = firstNameTextField.getText();
				String lastName = lastNameTextField.getText();
				int age = Integer.parseInt(ageTextField.getText());
				String email = emailTextField.getText();
				double salary = Double.parseDouble(salaryTextField.getText());
				String country = countryTextField.getText();
				String city = cityTextField.getText();
				String street = streetTextField.getText();
				
				
				
				
				Address address = new Address(country,city,street);
				
				
				Manager manager = new Manager(age,firstName,lastName,email,address,salary);
				
				managers.add(manager);
				
				
				int countManagers = managers.size();
				String convertedCountManagers = Integer.toString(countManagers);
				textField.setText(convertedCountManagers);
				 showManagersPanel = new JPanel();
				
				
				firstNameTextField.setText("");
				lastNameTextField.setText("");
				ageTextField.setText("");
				emailTextField.setText("");
				salaryTextField.setText("");
				countryTextField.setText("");
				cityTextField.setText("");
				streetTextField.setText("");
				
				
				layeredPane.add(showManagersPanel, "name_681415529124300");
				showManagersPanel.setLayout(null);
				
				String header[] = new String[]{"ID","First Name","Last Name","Email","Age","Salary","Country","City","Street"};
				
				table = new JTable();
				 DefaultTableModel dtm = new DefaultTableModel(header,0);
				 
				 dtm.setRowCount(0);
				for(int i=0;i<managers.size();i++) {
					Object[] objs = {managers.get(i).getId(),managers.get(i).getFirstName(),managers.get(i).getLastName(),managers.get(i).getEmail()
							,managers.get(i).getAge(),managers.get(i).getSalary(),managers.get(i).getAddress().getCountry()
							,managers.get(i).getAddress().getCity(),managers.get(i).getAddress().getStreet()}; 
					dtm.addRow(objs);
				}
				table.setModel(dtm);
				
				JScrollPane sp = new JScrollPane(table);
				
				sp.setBounds(0, 34, 741, 497);
		        
				 
				showManagersPanel.add(sp);
				
				
				OpenPanel(layeredPane,showManagersPanel);
				
			}
		});
		addManagerBtn.setBounds(138, 466, 97, 25);
		managerPanel.add(addManagerBtn);
		
		
		
		JLabel lblNewLabel_1 = new JLabel("Current Managers");
		lblNewLabel_1.setBounds(328, 466, 114, 25);
		managerPanel.add(lblNewLabel_1);
		
		JButton showManagersBtn = new JButton("Show");
		showManagersBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				OpenPanel(layeredPane,showManagersPanel);
			}
		});
		showManagersBtn.setBounds(12, 466, 97, 25);
		managerPanel.add(showManagersBtn);
		
		JPanel factoryWorkerPanel = new JPanel();
		layeredPane.add(factoryWorkerPanel, "name_671969917069600");
		factoryWorkerPanel.setLayout(null);
		
		JLabel lblNewLabel_2 = new JLabel("factoryworker");
		lblNewLabel_2.setBounds(100, 33, 56, 16);
		factoryWorkerPanel.add(lblNewLabel_2);
		
		JPanel salesPersonPanel = new JPanel();
		layeredPane.add(salesPersonPanel, "name_672516319241300");
		
		JLabel lblNewLabel = new JLabel("salesperson");
		salesPersonPanel.add(lblNewLabel);
		
		JPanel secretaryPanel = new JPanel();
		layeredPane.add(secretaryPanel, "name_673475818289500");
		secretaryPanel.setLayout(null);
		
		JLabel lblNewLabel_3 = new JLabel("secretary");
		lblNewLabel_3.setBounds(128, 70, 56, 16);
		secretaryPanel.add(lblNewLabel_3);
		
		
		
		
		
		JPanel mainPanel = new JPanel();
		mainPanel.setBounds(0, 41, 43, -31);
		frame.getContentPane().add(mainPanel);
		mainPanel.setLayout(null);
		
		JLabel introLabel = new JLabel("Choose for which object you want to fill the data");
		introLabel.setBounds(12, 13, 287, 96);
		frame.getContentPane().add(introLabel);
		
		JButton managerInputBtn = new JButton("Manager");
		managerInputBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			OpenPanel(layeredPane,managerPanel);
			
			}
		});
		managerInputBtn.setBounds(46, 122, 141, 43);
		frame.getContentPane().add(managerInputBtn);
		
		JButton secretaryInputBtn = new JButton("Secretary");
		secretaryInputBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				OpenPanel(layeredPane,secretaryPanel);
			}
		});
		secretaryInputBtn.setBounds(46, 190, 141, 43);
		frame.getContentPane().add(secretaryInputBtn);
		
		JButton salesPersonInputBtn = new JButton("SalesPerson");
		salesPersonInputBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				OpenPanel(layeredPane,salesPersonPanel);
			}
		});
		salesPersonInputBtn.setBounds(46, 269, 141, 49);
		frame.getContentPane().add(salesPersonInputBtn);
		
		JButton factoryWorkerInputBtn = new JButton("FactoryWorker");
		factoryWorkerInputBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				OpenPanel(layeredPane,factoryWorkerPanel);
			}
		});
		factoryWorkerInputBtn.setBounds(46, 350, 141, 49);
		frame.getContentPane().add(factoryWorkerInputBtn);
		
		
		frame.setBounds(100, 100, 1144, 624);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
}
