package application;
import java.awt.Button;
import javafx.event.ActionEvent;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.net.URL;
import java.rmi.RemoteException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Optional;
import java.util.ResourceBundle;

import javafx.beans.property.SimpleStringProperty;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;
import javafx.scene.control.Alert.AlertType;
import se.lu.ics.ExamDTO;
import se.lu.ics.FacultyDTO;
import se.lu.ics.KebabUniServiceSoap;
import se.lu.ics.KebabUniServiceSoapProxy;
import se.lu.ics.StudentDTO;

public class ExamsController implements Initializable {
		private KebabUniServiceSoap web = new KebabUniServiceSoapProxy();
	    ObservableList<ExamDTO> examList = FXCollections.observableArrayList();
	    
	 @FXML
	 private TableColumn<ExamDTO, String> columnCourseId;

	 @FXML
	 private TableColumn<ExamDTO, String> columnCredits;

	 @FXML
	 private TableColumn<ExamDTO, String> columnExamDate;

	 @FXML
	 private TableColumn<ExamDTO, String> columnExamId;

	 @FXML
	 private TableColumn<ExamDTO, String> columnRoom;

    @FXML
    private Label lblResponse;

    @FXML
    private TableView<ExamDTO> tblViewExam;

    @FXML
    private TextArea txtError;
    private Main main;
    private Stage stage;
	private Scene scene;
	private AnchorPane root;

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
    void btnSwitchToResults(ActionEvent event) throws Exception {
    	FXMLLoader loader = new FXMLLoader(getClass().getResource("ResultsScene.fxml"));
		root = loader.load();
		stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
		scene = new Scene(root);

		stage.setScene(scene);
		stage.show();

		ResultController resultController = loader.getController();
		resultController.setMain(main);

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
    
    @Override
	public void initialize(URL url, ResourceBundle resourceBundle) {
		
			 

			    try { 
			        ExamDTO[] examDtos = web.getExams();
			        
			        for (ExamDTO exam : examDtos) {
			        	ExamDTO examCopy = new ExamDTO(
			        			   exam.getExamID(),
			        	           exam.getCourse(),
			        	           exam.getRoom(),
			        	           exam.getExamDate() ,
			        	           exam.getCredits(),
			        	           exam.getResults()
			               
			            );
			        	examList.add(examCopy);
			            
			            
			          
			        }
			        
			    } catch (RemoteException e) {
			    	txtError.setText(e.getMessage());
			    }
			    
			 

		columnExamId.setCellValueFactory(new PropertyValueFactory<>("examID"));
		columnCourseId.setCellValueFactory(cellData -> {
		    String courseId = cellData.getValue().getCourse().getCourseId();
		    return new SimpleStringProperty(courseId);
		});
		columnRoom.setCellValueFactory(new PropertyValueFactory<>("room"));
		columnExamDate.setCellValueFactory(cellData -> {
		    SimpleStringProperty property = new SimpleStringProperty();
		    if (cellData.getValue().getExamDate() != null) {
		        DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");
		        property.setValue(dateFormat.format(cellData.getValue().getExamDate().getTime()));
		    }
		    return property;
		});
		columnCredits.setCellValueFactory(new PropertyValueFactory<>("credits"));
		
		tblViewExam.setItems(examList);

	}

    
    public void setMain(Main main) {
		
		this.main = main;
	}
	public Main getMain() 
	{
		return this.main;
	}

}
