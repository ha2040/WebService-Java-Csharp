package application;

import java.io.IOException;
import java.net.URL;
import java.rmi.RemoteException;
import java.util.List;
import java.util.Optional;
import java.util.ResourceBundle;

import javafx.beans.property.SimpleStringProperty;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.ButtonType;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Label;
import javafx.scene.control.Spinner;
import javafx.scene.control.SpinnerValueFactory;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;
import se.lu.ics.*;

public class CoursesController implements Initializable {
	private KebabUniServiceSoap web = new KebabUniServiceSoapProxy();
	private ObservableList<CourseDTO> cList= FXCollections.observableArrayList();
	private ObservableList<FacultyDTO> fList = FXCollections.observableArrayList();
	private ObservableList<EmployeeDTO> eList = FXCollections.observableArrayList();
	private Main main;
	private Stage stage;
	private Scene scene;
	private AnchorPane root;
	private String inLineCss = "-fx-border-style: solid; -fx-border-radius: 3px; -fx-border-width: 0.4px; -fx-border-color: red";
	private String inLineCssHide = "-fx-border-: transparent";

	@FXML
	private TableView<CourseDTO> tblViewCourses;
	@FXML
	private TableColumn<CourseDTO, String> courseIdColumn;
	@FXML
	private TableColumn<CourseDTO, String> facultyIdColumn;
	@FXML
	private TableColumn<CourseDTO, Double> creditsColumn;
	@FXML
	private TableColumn<CourseDTO, String> descriptionColumn;
	@FXML
	private TableColumn<CourseDTO, String> empIdColumn;
	@FXML
	private ComboBox<String> comboBoxFaculty;
	@FXML
	private ComboBox<String> comboBoxEmployee;
	@FXML
	private TextField txtFieldDescription;
	@FXML
	private Spinner<Double> spinnerCredits;
	@FXML
	private Label lblResponse;
	@FXML
	private Label lblResponseCourseName;
	@FXML
	private Button btnCreateCourse;
	@FXML
	private Button btnDeleteCourse;
	@FXML
	private Button btnViewExams;
	@FXML
	private Button btnUpdateCourse;
	@FXML
	private TextArea txtError;

	SpinnerValueFactory<Double> valueFactory = new SpinnerValueFactory.DoubleSpinnerValueFactory(1, 30);

	double currentValue;

	// setters and getters
	public void setMain(Main main) {
		this.main = main;
	}

	public Main getMain() {
		return main;
	}

	public Stage getStage() {
		return stage;
	}

	public void setStage(Stage stage) {
		this.stage = stage;
	}

	public Scene getScene() {
		return scene;
	}

	public void setScene(Scene scene) {
		this.scene = scene;
	}

	public AnchorPane getRoot() {
		return root;
	}

	public void setRoot(AnchorPane root) {
		this.root = root;
	}

	public String getInLineCss() {
		return inLineCss;
	}

	public void setInLineCss(String inLineCss) {
		this.inLineCss = inLineCss;
	}

	public String getInLineCssHide() {
		return inLineCssHide;
	}

	public void setInLineCssHide(String inLineCssHide) {
		this.inLineCssHide = inLineCssHide;
	}
	
	private void updateComboBox() {
		
		 
	}
	// methods
	@FXML
	public void btnToStudentStudy(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("StudentStudyScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		StudentStudyController studentStudyController = loader.getController();
		// DENNA FÅR ÄNDRAS AV DEN SOM GÖR STUDENTSTUDY TILL RÄTT CONTROLLER 
		studentStudyController.setMain(main);
	}
	@FXML
	public void btnSwitchToFaculties(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("FacultyScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		FacultyController facultyController = loader.getController();
		facultyController.setMain(main);
	}
	@FXML
	public void btnSwitchToEmployees(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("EmployeeScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		EmployeeController employeeController = loader.getController();
		employeeController.setMain(main);
	}

	@FXML
	public void btnSwitchToHome(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("HomeScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		HomeController homeController = loader.getController();
		homeController.setMain(main);
	}

	@FXML
	public void btnSwitchToStudents(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("StudentsScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		StudentsController studentsController = loader.getController();
		studentsController.setMain(main);
	}

	@FXML
	public void btnSwitchToCourses(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("CoursesScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		CoursesController coursesController = loader.getController();
		coursesController.setMain(main);
	}
	
	@FXML
	public void btnSwitchToExams(ActionEvent event) throws Exception {
		FXMLLoader loader = new FXMLLoader(getClass().getResource("ExamsScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		ExamsController examsController = loader.getController();
		examsController.setMain(main);
	}
	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
	


		 try { 

			cList = FXCollections.observableArrayList(web.getCourses());
		  

		
	
		courseIdColumn.setCellValueFactory(new PropertyValueFactory<CourseDTO, String>("courseId"));
		facultyIdColumn.setCellValueFactory(cellData -> {
		    String facultyName = cellData.getValue().getFaculty().getFacultyId();
		    return new SimpleStringProperty(facultyName);
		});
		creditsColumn.setCellValueFactory(new PropertyValueFactory<CourseDTO, Double>("credits"));
		descriptionColumn.setCellValueFactory(new PropertyValueFactory<CourseDTO, String>("description"));
		empIdColumn.setCellValueFactory(cellData -> {
		    String empId = cellData.getValue().getEmployee().getEmpId();
		    return new SimpleStringProperty(empId);
		});
	    tblViewCourses.setItems(cList);

	}      
	     catch (RemoteException ex) {
	    		txtError.setText("something went wrong, please restart application and \n cand call support!");
		    }

}
}
